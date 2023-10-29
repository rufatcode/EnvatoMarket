using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.SliderVM;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles ="Admin,SupperAdmin")]
    public class SliderController : Controller
    {
        // GET: /<controller>/
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        public SliderController(ISliderService sliderService,IMapper mapper,IFileService fileService)
        {
            _sliderService = sliderService;
            _mapper = mapper;
            _fileService = fileService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _sliderService.GetAll());
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CreateSliderVM sliderVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else if (!_fileService.IsImage(sliderVM.Image))
            {
                ModelState.AddModelError("Image", "Please enter only Image");
                return View();
            }
            else if (!_fileService.IsLengthSuit(sliderVM.Image,1000))
            {
                ModelState.AddModelError("Image", "Length is greater than 1kb");
                return View();
            }
            string fileName = _fileService.CreateImage(sliderVM.Image);
            Slider slider = _mapper.Map<Slider>(sliderVM);
            slider.ImageUrl = fileName;
            slider.Id = Guid.NewGuid().ToString();
           bool resoult= await _sliderService.Create(slider);
            if (resoult==false)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "SupperAdmin")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id==null)
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            bool resoult =await _sliderService.Delete(id);
            if (!resoult)
            {
                return BadRequest();
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "SupperAdmin")]
        public async Task<IActionResult> Update(string id)
        {
            if (id==null)
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            else if (!await _sliderService.IsExist(s=>s.Id==id))
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            Slider slider =await _sliderService.GetEntity(s => s.Id == id);
            
            UpdateSliderVM updateSliderVM = _mapper.Map<UpdateSliderVM>(slider);
            return View(updateSliderVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult>Update(string id,UpdateSliderVM updateSliderVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Slider oldSlider = await _sliderService.GetEntity(s => s.Id == id);
            _mapper.Map(updateSliderVM,oldSlider);
            if (updateSliderVM.Image != null)
            {
                if (!_fileService.IsImage(updateSliderVM.Image))
                {
                    ModelState.AddModelError("Image", "Please enter only Image");
                    return View();
                }
                else if (!_fileService.IsLengthSuit(updateSliderVM.Image, 1000))
                {
                    ModelState.AddModelError("Image", "Length is greater than 1kb");
                    return View();
                }
                _fileService.DeleteImage(oldSlider.ImageUrl);
               oldSlider.ImageUrl= _fileService.CreateImage(updateSliderVM.Image);
                
            }
            //slider.Id = id;
            bool resoult= await _sliderService.Update(oldSlider);
            if (!resoult)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(string id)
        {
            if (id==null)
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            else if (!await _sliderService.IsExist(s=>s.Id==id))
            {
                return BadRequest();
            }
            return View(await _sliderService.GetEntity(s=>s.Id==id));
        }
    }
}

