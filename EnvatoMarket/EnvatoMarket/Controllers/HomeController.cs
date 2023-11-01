using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.HomeVM;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using Product = EnvatoMarket.Core.Models.Product;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IAuthorService _authorService;
        private readonly IBlogService _blogService;
        private readonly IBrandService _brandService;
        private readonly IFeatureService _featureService;
        public HomeController(IFeatureService featureService,IBrandService brandService,IBlogService blogService,IAuthorService authorService,ISliderService sliderService,ICategoryService categoryService,IProductService productService)
        {
            _brandService = brandService;
            _blogService = blogService;
            _sliderService = sliderService;
            _categoryService = categoryService;
            _productService = productService;
            _authorService = authorService;
            _featureService = featureService;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            HomeIndexVM homeIndexVM = new();
            homeIndexVM.Sliders = await _sliderService.GetAll(s=>!s.IsDeleted);
            homeIndexVM.Categories = await _categoryService.GetAll(c=>!c.IsDeleted);
            homeIndexVM.Products = await _productService.GetAll(p => !p.IsDeleted, "Category", "Brand", "ProductImages", "ProductTags.Tag");
            homeIndexVM.Authors = await _authorService.GetAll(a=>!a.IsDeleted);
            homeIndexVM.Blogs = await _blogService.GetAll(b => !b.IsDeleted);
            homeIndexVM.Brands = await _brandService.GetAll(b => !b.IsDeleted);
            homeIndexVM.Features = await _featureService.GetAll(f => !f.IsDeleted);
            return View(homeIndexVM);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public async Task<IActionResult> SearchByCategory(string id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            List<Product> products = await _productService.GetAll(p => !p.IsDeleted, "Category", "Brand", "ProductImages", "ProductTags.Tag");
            if (id == "0")
            {
                return PartialView("_ProductPartial", products);
            }
            if (!await _categoryService.IsExist(c=>c.Id==id&&!c.IsDeleted))
            {
                return BadRequest();
            }
            
            
            Category category = await _categoryService.GetEntity(c => c.Id == id);
            
            var data = products.Where(p => p.Category.Id == id).ToList();
           
            return PartialView("_ProductPartial",data);
            
        }
    }
}

