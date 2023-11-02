using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.SingleProductVM;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Controllers
{
    public class SingleProductController : Controller
    {
        // GET: /<controller>/
        private readonly IProductService _productService;
        public SingleProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index(string id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            else if (!await _productService.IsExist(p=>p.Id==id))
            {
                return BadRequest();
            }
            ProductVM productVM = new();
            productVM.Product = await _productService.GetEntity(p => p.Id == id, "Category", "Brand", "ProductImages", "ProductTags.Tag", "Comments");
            productVM.Products = await _productService.GetAll(p => !p.IsDeleted && p.IsAvailability, "ProductImages");
            return View(productVM);
        }
    }
}

