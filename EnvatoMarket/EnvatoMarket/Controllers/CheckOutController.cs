using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.BasketsVM;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly IAdressSrevice _adressSrevice;
        public CheckOutController(IProductService productService,ICheckService checkService,ICheckProductService checkProductService, IBasketServices basketServices, UserManager<AppUser> userManager,IAdressSrevice adressSrevice)
        {
            _checkProductService = checkProductService;
            _checkService = checkService;
            _basketServices = basketServices;
            _userManager = userManager;
            _productService = productService;
            _adressSrevice = adressSrevice;
        }
        public async Task<IActionResult> Index()
        {
            CheckOutVM checkOutVM = new();
            checkOutVM.basketVMs = await _basketServices.Show();
            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser =await _userManager.FindByNameAsync(User.Identity.Name);
                checkOutVM.appUser = appUser;
            }
            if (checkOutVM.basketVMs.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            if (checkOutVM.basketVMs.Count==0)
            {
                return RedirectToAction("Index", "Home");
            }
            checkOutVM.Adresses = await _adressSrevice.GetAll(a => !a.IsDeleted&&a.AppUser.UserName==User.Identity.Name, "AppUser");
            return View(checkOutVM);
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
        [Authorize]
        public async Task<IActionResult> CheckOut(string adressId,string saleCode)
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
            if (adressId == null)
            {
                return BadRequest();
            }
            else if (!await _adressSrevice.IsExist(a => a.Id == adressId & !a.IsDeleted))
            {
                return BadRequest();
            }
            var Products = await _productService.GetAll(p=>!p.IsDeleted);
            foreach (var productInBasket in productInBaskets)
            {
                if (Products.Any(p => p.Id == productInBasket.Id && p.Count < productInBasket.ProductCount))
                {
                    TempData["AlertMessage"] = $"{productInBasket.Name} count is {Products.FirstOrDefault(p => p.Id == productInBasket.Id).Count} in stock";
                    return RedirectToAction("Index", "CheckOut");
                }
            }
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            var domain = "http://localhost:5771/";
            var options = new SessionCreateOptions
            {
                SuccessUrl = domain + $"CheckOut/ConfirmBasket",
                CancelUrl = domain + "Account/Login",
                LineItems = new List<SessionLineItemOptions>(),
                Mode = "payment",
                CustomerEmail = user.Email,



            };
            var products =await _basketServices.Show();
            double sale = 0.0;
            if (saleCode!=null&&saleCode.ToUpper()== "FREESHIPPING")
            {
                sale = 35.0;
            }
            foreach (var product in products)
            {
                var sessionListItem = new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)((product.Price+product.Tax/product.ProductCount) * 100-sale*100/(products.Count*product.ProductCount)),
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = product.Name.ToString()

                        }
                    },
                    Quantity = product.ProductCount
                    
                };
                options.LineItems.Add(sessionListItem);
            }
            var service = new SessionService();
            Session session = service.Create(options);
            TempData["Session"] = session.Id;
            TempData["AddressId"] = adressId;
            TempData["SaleCode"] = saleCode==null?" ":saleCode;
            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }
        [Authorize]
        public async Task<IActionResult> ConfirmBasket( )
        {
           
            var service = new SessionService();
            Session session = service.Get(TempData["Session"].ToString());
            if (session.PaymentStatus == "paid")
            {
                var productInBaskets =await _basketServices.Show();
                Check check = new();
                check.Id = Guid.NewGuid().ToString();
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                check.Created = DateTime.Now;
                check.AdressId = (TempData["AddressId"]).ToString();
                double totalAmmount = 0;
                foreach (var product in productInBaskets)
                {

                    totalAmmount += product.Price * product.ProductCount;
                    Product existProduct = await _productService.GetEntity(p=>p.Id==product.Id);

                    CheckProduct checkProduct = new() { CheckId = check.Id, ProductId = existProduct.Id, Price = existProduct.Price, ProductCount = product.ProductCount };
                    check.CheckProducts.Add(checkProduct);
                }
                check.TotalAmmount = totalAmmount;
                
                if ((TempData["SaleCode"]).ToString().ToUpper() == "FREESHIPPING")
                {
                    check.Sale = 35.0;
                }
                check.Sale = 0;


               bool isSuccess= await  _checkService.Create(check);
                if (!isSuccess)
                {
                    return BadRequest();
                }
                TempData["SuccessMessage"] = $"Payment successfully complated Payent ammount:{productInBaskets.Sum(p => p.Price * p.ProductCount)}$";
                foreach (var product in productInBaskets)
                {

                    Product existProduct = await _productService.GetEntity(p => p.Id == product.Id);

                    existProduct.Count -= product.ProductCount;
                    await _productService.Update(existProduct);
                }
                Response.Cookies.Delete("Basket");
                
            }
            else
            {
                TempData["SuccessMessage"] = "Something went wrong";
            }


            return RedirectToAction("Index", "CheckOut");
        }
    }
}

