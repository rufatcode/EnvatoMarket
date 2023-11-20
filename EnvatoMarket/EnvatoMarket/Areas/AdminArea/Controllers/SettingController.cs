using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.Services;
using EnvatoMarket.Business.ViewModels.SettingsVM;
using EnvatoMarket.Business.ViewModels.TagVM;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin,SupperAdmin")]
    public class SettingController : Controller
    {
        // GET: /<controller>/
        private readonly IMapper _mapper;
        private readonly ISettingService _settingService;
        public SettingController(IMapper mapper,ISettingService settingService)
        {
            _mapper = mapper;
            _settingService = settingService;
        }
        public async Task<IActionResult> Pagination(int skip, int take = 4)
        {
            var data = await _settingService.GetAll();
            return PartialView("_SettingPartial", data.Skip(skip).Take(take).ToList());
        }
        public async Task<IActionResult> Index()
        {
            var data = await _settingService.GetAll();
            ViewBag.ProductCount = data.Count;
            return View(data.Take(4).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CreateSettingVM createSettingVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else if (await _settingService.IsExist(s => s.Key.ToLower() == createSettingVM.Key.ToLower()))
            {
                ModelState.AddModelError("Key", "Key is exist");
                return View();
            }
            Setting setting = _mapper.Map<Setting>(createSettingVM);
            setting.AddedBy = User.Identity.Name.ToString();
            setting.Id = Guid.NewGuid().ToString();

            bool isSuccess = await _settingService.Create(setting);
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
            bool isSuccess = await _settingService.Delete(id);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "SupperAdmin")]
        public async Task<IActionResult> Update(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else if (!await _settingService.IsExist(s => s.Id == id))
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            Setting setting = await _settingService.GetEntity(s => s.Id == id);

            return View(_mapper.Map<UpdateSettingVM>(setting));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(string id, UpdateSettingVM updateSettingVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Setting setting = await _settingService.GetEntity(s => s.Id == id);
            if (await _settingService.IsExist(s => s.Key.ToLower() == updateSettingVM.Key.ToLower() && updateSettingVM.Key.ToLower() != setting.Key.ToLower()))
            {
                ModelState.AddModelError("Key", "This Key is exist");
                return View();
            }
            _mapper.Map(updateSettingVM, setting);
            bool isSuccess = await _settingService.Update(setting);
            if (!isSuccess)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}

