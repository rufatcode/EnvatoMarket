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
        private readonly ISettingService _settingService;
        private readonly IContactService _contactService;
        private readonly ISubscribeService _subscribeService;
        public HomeController(ISubscribeService subscribeService,IContactService contactService,ISettingService settingService,IBlogService blogService,IAuthorService authorService,ISliderService sliderService,ICategoryService categoryService,IProductService productService)
        {
            _subscribeService = subscribeService;
            _contactService = contactService;
            _blogService = blogService;
            _sliderService = sliderService;
            _categoryService = categoryService;
            _productService = productService;
            _authorService = authorService;
            _settingService = settingService;
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
            return View(homeIndexVM);
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateConnection(string name,string email,string subject,string message)
        {
            if (name==null||email==null||subject==null||message==null||email.Length<5)
            {
                TempData["Info"] = "Something went wrong";
                return RedirectToAction("Contact");
            }
            await _contactService.Create(new Contact
            {
                Id = Guid.NewGuid().ToString(),
                UserName=name,
                Email=email,
                Subject=subject,
                Message=message
            }) ;
            TempData["Info"] = "Messaje Successfully sended";
            return RedirectToAction("Contact");
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
            else if (id == "1")
            {
                return PartialView("_ProductPartial", products.OrderByDescending(p=>p.Created).ToList());
            }
            if (!await _categoryService.IsExist(c=>c.Id==id&&!c.IsDeleted))
            {
                return BadRequest();
            }
            
            
            Category category = await _categoryService.GetEntity(c => c.Id == id);
            
            var data = products.Where(p => p.Category.Id == id).ToList();
           
            return PartialView("_ProductPartial",data);
            
        }
       
        public async Task<IActionResult>SearchByProduct(string categoryId)
        {
            List<string> productNames = new();
            if (categoryId=="0")
            {
                
                List<Product> products = await _productService.GetAll(c => !c.IsDeleted);
                foreach (var product in products)
                {
                    productNames.Add(product.Name);
                }
                return Ok(productNames);
            }
            else if (categoryId==null)
            {
                return BadRequest();
            }
            else if (!await _categoryService.IsExist(c=>c.Id==categoryId))
            {
                return BadRequest();
            }
            Category category = await _categoryService.GetEntity(c => !c.IsDeleted&&c.Id==categoryId, "Products");
            foreach (var product in category.Products)
            {
                productNames.Add(product.Name);
            }
            return Ok(productNames);
        }
        public async Task<IActionResult>GetProductByName(string productName)
        {
            if (productName == null)
            {
                return RedirectToAction("Index");
            }
            else if (!await _productService.IsExist(p=>p.Name.ToLower()== productName.ToLower()&&!p.IsDeleted))
            {
                return RedirectToAction("Index");
            }
            Product product=await _productService.GetEntity(p => p.Name.ToLower() == productName.ToLower());
            return Redirect($"/SingleProduct/Index/{product.Id}");
        }
        public async Task<IActionResult> About()
        {
            return View(await _settingService.GetSettingByKeyValue(s=>!s.IsDeleted));
        }
        public async Task<IActionResult> Subscribe(string email)
        {
            if (await _subscribeService.IsExist(s=>s.Email.ToLower()==email.ToLower()))
            {
                TempData["Info"] = "Something went wrong";
                return RedirectToAction("Index");
            }
            else if (email.Length<6)
            {
                TempData["Info"] = "Something went wrong";
                return RedirectToAction("Index");
            }
            bool isSuccess= await _subscribeService.Create(new Subscribe
            {
                Id = Guid.NewGuid().ToString(),
                Email = email
            });
            if (!isSuccess)
            {
                return BadRequest();
            }
            TempData["Info"] = "Subscribe successfuly added";
            return RedirectToAction("Index");
        }
    }
}

