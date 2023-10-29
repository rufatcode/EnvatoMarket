using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.Services;
using EnvatoMarket.Business.ViewModels.CategoryVM;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin,SupperAdmin")]
    public class CategoryController : Controller
    {
        // GET: /<controller>/
        private readonly ICategoryService _categoryService;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService,IFileService fileService,IMapper mapper)
        {
            _categoryService = categoryService;
            _fileService = fileService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _categoryService.GetAll(null,"Parent"));
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.CategoryCount = (await _categoryService.GetAll()).Count;
            ViewBag.Categories = new SelectList(await _categoryService.GetAll(c => c.IsMain), "Id", "CategoryName");
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CreateCategoryVM createCategoryVM)
        {
            ViewBag.CategoryCount = (await _categoryService.GetAll()).Count;
            ViewBag.Categories = new SelectList(await _categoryService.GetAll(c => c.IsMain), "Id", "CategoryName");
            if (!ModelState.IsValid)
            {
                return View();
            }
            else if (!_fileService.IsImage(createCategoryVM.Image))
            {
                ModelState.AddModelError("Image", "Please enter only Image");
                return View();
            }
            else if (!_fileService.IsLengthSuit(createCategoryVM.Image, 1000))
            {
                ModelState.AddModelError("Image", "Length is greater than 1kb");
                return View();
            }
            string fileName = _fileService.CreateImage(createCategoryVM.Image);
            Category category = _mapper.Map<Category>(createCategoryVM);
            category.ImageUrl = fileName;
            category.Id = Guid.NewGuid().ToString();
            bool isSuccess = await _categoryService.Create(category);
            if (!isSuccess)
            {
                ModelState.AddModelError("","Something went wrong");
                return View();
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "SupperAdmin")]
        public async Task<IActionResult>Delete(string id)
        {
            if (id == null)
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            bool resoult = await _categoryService.Delete(id);
            if (!resoult)
            {
                return BadRequest();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult>Detail(string id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            else if (!await _categoryService.IsExist(c=>c.Id==id))
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            Category category = await _categoryService.GetEntity(c => c.Id == id, "Parent");

            return View(category);
        }
        [Authorize(Roles = "SupperAdmin")]
        public async Task<IActionResult> Update(string id)
        {
            ViewBag.CategoryCount = (await _categoryService.GetAll()).Count;
            ViewBag.Categories = new SelectList(await _categoryService.GetAll(c => c.IsMain), "Id", "CategoryName");
            if (id==null)
            {
                return BadRequest();
            }
            else if (!await _categoryService.IsExist(c=>c.Id==id))
            {
                return BadRequest();
            }
            Category category = await _categoryService.GetEntity(c => c.Id == id);
            UpdateCategoryVM updateCategoryVM = _mapper.Map<UpdateCategoryVM>(category);
            return View(updateCategoryVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult>Update(string id,UpdateCategoryVM updateCategoryVM)
        {
            ViewBag.CategoryCount = (await _categoryService.GetAll()).Count;
            ViewBag.Categories = new SelectList(await _categoryService.GetAll(c => c.IsMain), "Id", "CategoryName");
            if (!ModelState.IsValid)
            {
                return View();
            }
            Category category = await _categoryService.GetEntity(c => c.Id == id);
            if (updateCategoryVM.Image!=null)
            {
                if (!_fileService.IsImage(updateCategoryVM.Image))
                {
                    ModelState.AddModelError("Image", "Upload Only Image");
                    return View();
                }
                else if (!_fileService.IsLengthSuit(updateCategoryVM.Image,1000))
                {
                    ModelState.AddModelError("Image", "File length must be smaller than 1 kb");
                    return View();
                }
                category.ImageUrl = _fileService.CreateImage(updateCategoryVM.Image);
            }
            if (await _categoryService.IsExist(c=>c.CategoryName==updateCategoryVM.CategoryName&&updateCategoryVM.CategoryName!=category.CategoryName))
            {
                ModelState.AddModelError("CategoryName", "This Category is exist");
                return View();
            }
            _mapper.Map(updateCategoryVM, category);
            bool resoult = await _categoryService.Update(category);
            if (!resoult)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }

            return RedirectToAction("Index");
        }
    }
}

