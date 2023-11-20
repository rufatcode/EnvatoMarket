using System;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.BasketsVM;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace EnvatoMarket.Business.Services
{
    public class BasketServices : IBasketServices
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IProductService _productService;
        public BasketServices(IHttpContextAccessor httpContextAccessor, IProductService productService)
        {
            _httpContextAccessor = httpContextAccessor;
            _productService = productService;
        }

        public void Add(string id)
        {
            List<ProductToBasket> products = new();
            string data = _httpContextAccessor.HttpContext.Request.Cookies["Basket"];
            if (data == null)
            {
                _httpContextAccessor.HttpContext.Response.Cookies.Append("Basket", JsonConvert.SerializeObject(products), new CookieOptions { MaxAge = TimeSpan.FromDays(1) });
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<ProductToBasket>>(data);
            }
            if (products.Find(p => p.Id == id) != null)
            {
                products.Find(p => p.Id == id).ProductCount++;
            }
            else
            {
                products.Add(new() { Id = id, ProductCount = 1 });
            }

            _httpContextAccessor.HttpContext.Response.Cookies.Append("Basket", JsonConvert.SerializeObject(products));
        }
        public void Decrease(string id, string data)
        {
            List<ProductToBasket> productToBaskets = JsonConvert.DeserializeObject<List<ProductToBasket>>(data);
            if (productToBaskets.Find(p => p.Id == id).ProductCount == 1)
            {
                Remove(id, data);

            }
            else
            {
                productToBaskets.Find(p => p.Id == id).ProductCount--;
                _httpContextAccessor.HttpContext.Response.Cookies.Append("Basket", JsonConvert.SerializeObject(productToBaskets), new CookieOptions { MaxAge = TimeSpan.FromDays(1) });

            }
        }
        public void Increase(string id, string data)
        {
            List<ProductToBasket> productToBaskets = JsonConvert.DeserializeObject<List<ProductToBasket>>(data);
            productToBaskets.Find(p => p.Id == id).ProductCount++;
            _httpContextAccessor.HttpContext.Response.Cookies.Append("Basket", JsonConvert.SerializeObject(productToBaskets), new CookieOptions { MaxAge = TimeSpan.FromDays(1) });
        }
        public void Remove(string id, string data)
        {
            List<ProductToBasket> products = JsonConvert.DeserializeObject<List<ProductToBasket>>(data);
            products.Remove(products.Find(p => p.Id == id));
            _httpContextAccessor.HttpContext.Response.Cookies.Append("Basket", JsonConvert.SerializeObject(products), new CookieOptions { MaxAge = TimeSpan.FromDays(1) });
        }
        public async Task<List<BasketVM>> Show()
        {
            List<BasketVM> basketVMs = new();
            List<ProductToBasket> productToBaskets = new();
            string data = _httpContextAccessor.HttpContext.Request.Cookies["Basket"];
            if (data == null)
            {
                return basketVMs;
            }
            productToBaskets = JsonConvert.DeserializeObject<List<ProductToBasket>>(data);
            foreach (var item in productToBaskets)
            {
                Product exisctProduct = await _productService.GetEntity(p => p.Id == item.Id, "ProductImages");
                basketVMs.Add(new() { Id = exisctProduct.Id, Name = exisctProduct.Name, ImgSrc = exisctProduct.ProductImages.FirstOrDefault(pi=>pi.IsMain).ImageUrl, Price = exisctProduct.Price, ProductCount = item.ProductCount,Tax=exisctProduct.Tax });
            }
            return basketVMs;
        }
    }
}

