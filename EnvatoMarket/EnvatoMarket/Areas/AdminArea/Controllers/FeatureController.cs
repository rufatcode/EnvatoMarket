using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.Services;
using EnvatoMarket.Business.ViewModels.BlogVM;
using EnvatoMarket.Business.ViewModels.FeatureVM;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin,SupperAdmin")]
    public class FeatureController : Controller
    {
        // GET: /<controller>/
        private readonly IFeatureService _featureService;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;
        public FeatureController(IFeatureService featureService, IFileService fileService, IMapper mapper)
        {
            _featureService = featureService;
            _fileService = fileService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Pagination(int skip, int take = 4)
        {
            var data = await _featureService.GetAll();
            return PartialView("_FeaturePartial", data.Skip(skip).Take(take).ToList());
        }
        public async Task<IActionResult> Index()
        {
            var data = await _featureService.GetAll();
            ViewBag.ProductCount = data.Count;
            return View(data.Take(4).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CreateFeatureVM createFeatureVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else if (!_fileService.IsImage(createFeatureVM.Image))
            {
                ModelState.AddModelError("Image", "Please enter only Image");
                return View();
            }
            else if (!_fileService.IsLengthSuit(createFeatureVM.Image, 1000))
            {
                ModelState.AddModelError("Image", "Length is greater than 1kb");
                return View();
            }
            else if (await _featureService.IsExist(f=>f.Title.ToLower()==createFeatureVM.Title.ToLower()))
            {
                ModelState.AddModelError("Title", "Feature Title must be unique for every Feature");
                return View();
            }
            Feature feature = _mapper.Map<Feature>(createFeatureVM);
            feature.AddedBy = User.Identity.Name.ToString();
            feature.ImageUrl = _fileService.CreateImage(createFeatureVM.Image);
            feature.Id = Guid.NewGuid().ToString();
            bool isSuccess = await _featureService.Create(feature);
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
            bool resoult = await _featureService.Delete(id);
            if (!resoult)
            {
                return BadRequest();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else if (!await _featureService.IsExist(f => f.Id == id))
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            Feature feature = await _featureService.GetEntity(f => f.Id == id);

            return View(feature);
        }
        [Authorize(Roles = "SupperAdmin")]
        public async Task<IActionResult> Update(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else if (!await _featureService.IsExist(f => f.Id == id))
            {
                return BadRequest();
            }
            Feature feature = await _featureService.GetEntity(f => f.Id == id);
            UpdateFeatureVM updateFeatureVM = _mapper.Map<UpdateFeatureVM>(feature);
            return View(updateFeatureVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(string id, UpdateFeatureVM updateFeatureVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Feature feature = await _featureService.GetEntity(f => f.Id == id);
             if (await _featureService.IsExist(f => f.Title.ToLower() == updateFeatureVM.Title.ToLower()&&updateFeatureVM.Title.ToLower()!=feature.Title.ToLower()))
            {
                ModelState.AddModelError("Title", "Feature Title must be unique for every Feature");
                return View();
            }
            if (updateFeatureVM.Image != null)
            {
                if (!_fileService.IsImage(updateFeatureVM.Image))
                {
                    ModelState.AddModelError("Image", "Upload Only Image");
                    return View();
                }
                else if (!_fileService.IsLengthSuit(updateFeatureVM.Image, 1000))
                {
                    ModelState.AddModelError("Image", "File length must be smaller than 1 kb");
                    return View();
                }
                if (feature.ImageUrl!=null)
                {
                    _fileService.DeleteImage(feature.ImageUrl);
                }
                
                feature.ImageUrl = _fileService.CreateImage(updateFeatureVM.Image);
                
            }
            _mapper.Map(updateFeatureVM, feature);
            bool resoult = await _featureService.Update(feature);
            if (!resoult)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }

            return RedirectToAction("Index");
        }
    }
}

