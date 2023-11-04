using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.Services;
using EnvatoMarket.Business.ViewModels.SubscribeVM;
using EnvatoMarket.Business.ViewModels.TagVM;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin,SupperAdmin")]
    public class SubscribeController : Controller
    {
        // GET: /<controller>/
        private readonly ISubscribeService _subscribeService;
        private readonly IMapper _mapper;
        public SubscribeController(ISubscribeService subscribeService,IMapper mapper)
        {
            _subscribeService = subscribeService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _subscribeService.GetAll());
        }
        [Authorize(Roles = "SupperAdmin")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            bool isSuccess = await _subscribeService.Delete(id);
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
            else if (!await _subscribeService.IsExist(s => s.Id == id))
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            Subscribe subscribe = await _subscribeService.GetEntity(s => s.Id == id);

            return View(_mapper.Map<UpdateSubscribeVM>(subscribe));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(string id, UpdateSubscribeVM updateSubscribeVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Subscribe subscribe = await _subscribeService.GetEntity(s => s.Id == id);
            if (await _subscribeService.IsExist(s => s.Email.ToLower() == updateSubscribeVM.Email.ToLower() && updateSubscribeVM.Email.ToLower() != subscribe.Email.ToLower()))
            {
                ModelState.AddModelError("Name", "This tag is exist");
                return View();
            }
            _mapper.Map(updateSubscribeVM, subscribe);
            bool isSuccess = await _subscribeService.Update(subscribe);
            if (!isSuccess)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}

