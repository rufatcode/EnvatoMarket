using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.Services;
using EnvatoMarket.Business.ViewModels.BlogVM;
using EnvatoMarket.Business.ViewModels.BrandVM;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin,SupperAdmin")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        public BrandController(IBrandService brandService, IMapper mapper,IFileService fileService)
        {
            _brandService = brandService;
            _mapper = mapper;
            _fileService = fileService;
        }
        public async Task<IActionResult> Pagination(int skip, int take = 4)
        {
            var data = await _brandService.GetAll();
            return PartialView("_BrandPartial", data.Skip(skip).Take(take).ToList());
        }
        public async Task<IActionResult> Index()
        {
            var data = await _brandService.GetAll();
            ViewBag.ProductCount = data.Count;
            return View(data.Take(4).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CreateBrandVM createBrandVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else if (await _brandService.IsExist(b=>b.Name.ToLower()==createBrandVM.Name.ToLower()))
            {
                ModelState.AddModelError("Name", "Name is exist");
                return View();
            }
            else if (!_fileService.IsImage(createBrandVM.BrandImage))
            {
                ModelState.AddModelError("BrandImage", "Upload Only Image");
                return View();
            }
            else if (!_fileService.IsLengthSuit(createBrandVM.BrandImage, 1000))
            {
                ModelState.AddModelError("BrandImage", "File length must be smaller than 1 kb");
                return View();
            }
            Brand brand = _mapper.Map<Brand>(createBrandVM);
            brand.Id = Guid.NewGuid().ToString();
            brand.ImageUrl = _fileService.CreateImage(createBrandVM.BrandImage);
           brand.AddedBy = User.Identity.Name.ToString();
            bool isSuccess = await _brandService.Create(brand);
            if (!isSuccess)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "SupperAdmin")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            bool resoult = await _brandService.Delete(id);
            if (!resoult)
            {
                return BadRequest();
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "SupperAdmin")]
        public async Task<IActionResult>Update(string id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            else if (!await _brandService.IsExist(b=>b.Id==id))
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            Brand brand = await _brandService.GetEntity(b => b.Id == id);

            return View(_mapper.Map<UpdateBrandVM>(brand));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult>Update(string id,UpdateBrandVM updateBrandVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Brand brand = await _brandService.GetEntity(b => b.Id == id);
            if (await _brandService.IsExist(b=>b.Name.ToLower()==updateBrandVM.Name.ToLower()&&updateBrandVM.Name.ToLower()!=brand.Name.ToLower()))
            {
                ModelState.AddModelError("Name", "This brand is exist");
                return View();
            }
            if (updateBrandVM.BrandImage != null)
            {
                if (!_fileService.IsImage(updateBrandVM.BrandImage))
                {
                    ModelState.AddModelError("BrandImage", "Upload Only Image");
                    return View();
                }
                else if (!_fileService.IsLengthSuit(updateBrandVM.BrandImage, 1000))
                {
                    ModelState.AddModelError("BrandImage", "File length must be smaller than 1 kb");
                    return View();
                }
                if (brand.ImageUrl!=null)
                {
                    _fileService.DeleteImage(brand.ImageUrl);
                }
               
                brand.ImageUrl = _fileService.CreateImage(updateBrandVM.BrandImage);
               
            }
            _mapper.Map(updateBrandVM, brand);
            bool isSuccess=await _brandService.Update(brand);
            if (!isSuccess)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}

