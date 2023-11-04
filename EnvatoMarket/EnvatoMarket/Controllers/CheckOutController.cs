using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Controllers
{
    public class CheckOutController : Controller
    {
        // GET: /<controller>/
        private readonly ICheckProductService _checkProductService;
        private readonly ICheckService _checkService;
        private readonly IBasketServices _basketServices;
        private readonly IProductService _productService;
        private readonly UserManager<AppUser> _userManager;
        public CheckOutController(IProductService productService,ICheckService checkService,ICheckProductService checkProductService, IBasketServices basketServices, UserManager<AppUser> userManager)
        {
            _checkProductService = checkProductService;
            _checkService = checkService;
            _basketServices = basketServices;
            _userManager = userManager;
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            List<Check> data =await _checkService.GetAll(c=>!c.IsDeleted, "AppUser","CheckProducts.Product");
            return View(data);
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else if (!await _checkService.IsExist(c=>c.Id==id&&!c.IsDeleted))
            {
                return RedirectToAction("TokenIsNotValid","Account");
            }
            
            bool isSuccess= await _checkService.Delete(id);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> CheckOut()
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData["Warning"] = "Please Enter Personal Account for sales";
                return RedirectToAction("Login", "Account");
            }
            var productInBaskets =await _basketServices.Show();
            if (productInBaskets.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            var Products = await _productService.GetAll(p=>!p.IsDeleted);
            foreach (var productInBasket in productInBaskets)
            {
                if (Products.Any(p => p.Id == productInBasket.Id && p.Count < productInBasket.ProductCount))
                {
                    TempData["AlertMessage"] = $"{productInBasket.Name} count is {Products.FirstOrDefault(p => p.Id == productInBasket.Id).Count} in stock";
                    return RedirectToAction("Index", "Basket");
                }
            }
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            var domain = "http://localhost:5777/";
            var options = new SessionCreateOptions
            {
                SuccessUrl = domain + $"CheckOut/ConfirmBasket",
                CancelUrl = domain + "Account/Login",
                LineItems = new List<SessionLineItemOptions>(),
                Mode = "payment",
                CustomerEmail = user.Email,



            };
            var products =await _basketServices.Show();
            foreach (var product in products)
            {
                var sessionListItem = new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(product.ProductCount * product.Price) * 100,
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = product.Name.ToString(),

                        }
                    },
                    Quantity = product.ProductCount
                };
                options.LineItems.Add(sessionListItem);
            }
            var service = new SessionService();
            Session session = service.Create(options);
            TempData["Session"] = session.Id;
            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }
        public async Task<IActionResult> ConfirmBasket()
        {

            var service = new SessionService();
            Session session = service.Get(TempData["Session"].ToString());
            if (session.PaymentStatus == "paid")
            {
                var productInBaskets =await _basketServices.Show();
                Check check = new();
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                check.Created = DateTime.Now;
                check.UserId = appUser.Id;
                double totalAmmount = 0;
                foreach (var product in productInBaskets)
                {

                    totalAmmount += product.Price * product.ProductCount;
                    Product existProduct = await _productService.GetEntity(p=>p.Id==product.Id);

                    CheckProduct checkProduct = new() { CheckId = check.Id, ProductId = existProduct.Id, Price = existProduct.Price, ProductCount = product.ProductCount };
                    check.CheckProducts.Add(checkProduct);
                    existProduct.Count -= product.ProductCount;
                }
                check.TotalAmmount = totalAmmount;



               bool isSuccess= await  _checkService.Create(check);
                if (!isSuccess)
                {
                    return BadRequest();
                }
                TempData["SuccessMessage"] = $"Payment successfully complated Payent ammount:{productInBaskets.Sum(p => p.Price * p.ProductCount)}$";
                Response.Cookies.Delete("Basket");
            }
            else
            {
                TempData["SuccessMessage"] = "Something went wrong";
            }


            return RedirectToAction("Index", "Basket");
        }
    }
}

