using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Controllers
{
    [Authorize]
    public class BasketController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBasketServices _basketServices;
        public BasketController(IProductService productService, IBasketServices basketServices)
        {
            _productService = productService;
            _basketServices = basketServices;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _basketServices.Show());
        }
        public async Task<IActionResult> Basket(string id)
        {
            //Response.Cookies.Append("Test","Hello",new CookieOptions { MaxAge=TimeSpan.FromMinutes(20)});
            //HttpContext.Session.SetString("Test1", "Hi");
            //HttpContext.Session.Remove("Test1");
            Product existProduct =await _productService.GetEntity(p => p.Id == id);
            if (id == "0" || existProduct == null||existProduct.IsDeleted)
            {
                return RedirectToAction("Index", "Home");
            }
            _basketServices.Add(id);
            return RedirectToAction("Index","Home");
        }

        public async Task<IActionResult> RemoveProduct(string id)
        {
            Product existProduct = await _productService.GetEntity(p => p.Id == id);
            if (existProduct == null || id =="0"||existProduct.IsDeleted)
            {
                return Redirect("/Home/Index");
            }
            string data = Request.Cookies["Basket"];
            if (data == null)
            {
                return Redirect("/Home/Index");
            }
            _basketServices.Remove(id, data);
            return Redirect("/Home/Index");
        }
        public async Task<IActionResult> IncreaseProduct(string id)
        {
            Product existProduct = await _productService.GetEntity(p => p.Id == id);
            if (existProduct == null || id == "0"||existProduct.IsDeleted)
            {
                return RedirectToAction("Index", "Home");
            }
            string data = Request.Cookies["Basket"];
            if (data == null)
            {
                return RedirectToAction("Index", "Home");
            }

            _basketServices.Increase(id, data);
            return RedirectToAction("Index","CheckOut");
        }
        public async Task<IActionResult> DecreaseProduct(string id)
        {
            Product existProduct = await _productService.GetEntity(p => p.Id == id);
            if (existProduct == null || id == "0"||existProduct.IsDeleted)
            {
                return RedirectToAction("Index", "Home");
            }
            string data = Request.Cookies["Basket"];
            if (data == null)
            {
                return RedirectToAction("Index", "Product");
            }

            _basketServices.Decrease(id, data);
            return RedirectToAction("Index", "CheckOut");
        }

    }
}

