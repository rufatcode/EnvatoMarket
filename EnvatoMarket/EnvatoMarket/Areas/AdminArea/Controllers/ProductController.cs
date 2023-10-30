using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.ProductVM;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin,SupperAdmin")]
    public class ProductController : Controller
    {
        // GET: /<controller>/
        private readonly IProductService  _productService;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        private readonly ITagService _tagService;
        public ProductController(IProductService productService, IFileService fileService, IMapper mapper,ICategoryService categoryService,IBrandService brandService,ITagService tagService)
        {
            _productService = productService;
            _fileService = fileService;
            _mapper = mapper;
            _categoryService = categoryService;
            _tagService = tagService;
            _brandService = brandService;
        }
        public async Task<IActionResult> Index()
        {
            List<Product> products = await _productService.GetAll();
            if (products.Count > 0)
            {
                return View(await _productService.GetAll(null, "Category", "Brand", "ProductImages", "ProductTags.Tag"));
            }
            return View(await _productService.GetAll());
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Brand = new SelectList(await _brandService.GetAll(b => !b.IsDeleted), "Id", "Name");
            ViewBag.Tags = new SelectList(await _tagService.GetAll(t => !t.IsDeleted), "Id", "Name");
            ViewBag.Category = new SelectList(await _categoryService.GetAll(c => !c.IsDeleted), "Id", "CategoryName");
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CreateProductVM createProductVM)
        {
            ViewBag.Brand = new SelectList(await _brandService.GetAll(b => !b.IsDeleted),"Id", "Name");
            ViewBag.Tags = new SelectList(await _tagService.GetAll(t => !t.IsDeleted), "Id", "Name");
            ViewBag.Category = new SelectList(await _categoryService.GetAll(c => !c.IsDeleted), "Id", "CategoryName");
            if (!ModelState.IsValid)
            {
                return View();
            }
            else if (await _productService.IsExist(p=>p.Name.ToLower()==createProductVM.Name.ToLower()))
            {
                ModelState.AddModelError("Name", "Name must be unique for evey Product");
                return View();
            }
            if (!_fileService.IsImage(createProductVM.MainImage)||!_fileService.IsImage(createProductVM.HoverImage))
            {
                ModelState.AddModelError("", "Upload Only Image");
                return View();
            }
            else if (!_fileService.IsLengthSuit(createProductVM.MainImage,1000) || !_fileService.IsLengthSuit(createProductVM.HoverImage,1000))
            {
                ModelState.AddModelError("", "File size must be smaller than 1 kb");
                return View();
            }
            foreach (var exImage in createProductVM.ExtraImages)
            {
                if (!_fileService.IsImage(exImage))
                {
                    ModelState.AddModelError("", "Upload Only Image");
                    return View();
                }
                else if (!_fileService.IsLengthSuit(exImage, 1000))
                {
                    ModelState.AddModelError("", "File size must be smaller than 1 kb");
                    return View();
                }
            }
            Product product = _mapper.Map<Product>(createProductVM);
            product.Id = Guid.NewGuid().ToString();
            product.StarsCount = 0;
            product.ProductImages.Add(new ProductImage {
                Id=Guid.NewGuid().ToString(),
                ProductId=product.Id,
                IsMain=true,
                ImageUrl=_fileService.CreateImage(createProductVM.MainImage)
                });
            product.ProductImages.Add(new ProductImage
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = product.Id,
                IsHover = true,
                ImageUrl = _fileService.CreateImage(createProductVM.HoverImage)
            });
            foreach (var tagId in createProductVM.TagIds)
            {
                product.ProductTags.Add(new ProductTag
                {
                    Id = Guid.NewGuid().ToString(),
                    ProductId = product.Id,
                    TagId =tagId
                });
            }
           
            foreach (var exImage in createProductVM.ExtraImages)
            {
                product.ProductImages.Add(new ProductImage
                {
                    Id = Guid.NewGuid().ToString(),
                    ProductId = product.Id,
                    ImageUrl = _fileService.CreateImage(exImage)
                });
            }
            product.ProductCode = Guid.NewGuid().ToString().Substring(3, 10);
            bool isSuccess = await _productService.Create(product);
            if (!isSuccess)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult>Delete(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            bool resoult = await _productService.Delete(id);
            if (!resoult)
            {
                return BadRequest();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(string id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            else if (!await _productService.IsExist(p=>p.Id==id))
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            return View(await _productService.GetEntity(null, "Category", "Brand", "ProductImages", "ProductTags.Tag"));
        }
    }
}

