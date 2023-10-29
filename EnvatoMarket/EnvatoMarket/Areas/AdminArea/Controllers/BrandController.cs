using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.Services;
using EnvatoMarket.Business.ViewModels.BrandVM;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin,SupperAdmin")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IMapper _mapper;
        public BrandController(IBrandService brandService, IMapper mapper)
        {
            _brandService = brandService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _brandService.GetAll());
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
            Brand brand = _mapper.Map<Brand>(createBrandVM);
            brand.Id = Guid.NewGuid().ToString();
            
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

