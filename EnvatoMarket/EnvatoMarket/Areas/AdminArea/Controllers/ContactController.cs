using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.Services;
using EnvatoMarket.Business.ViewModels.ContactVM;
using EnvatoMarket.Business.ViewModels.TagVM;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin,SupperAdmin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        public ContactController(IContactService contactService,IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _contactService.GetAll());
        }
        [Authorize(Roles = "SupperAdmin")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            bool isSuccess = await _contactService.Delete(id);
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
            else if (!await _contactService.IsExist(c => c.Id == id))
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            Contact contact = await _contactService.GetEntity(b => b.Id == id);

            return View(_mapper.Map<UpdateContactVM>(contact));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(string id, UpdateContactVM updateContactVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Contact contact = await _contactService.GetEntity(c => c.Id == id);
            
            _mapper.Map(updateContactVM, contact);
            bool isSuccess = await _contactService.Update(contact);
            if (!isSuccess)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(string id)
        {
            if (id == null)
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            else if (!await _contactService.IsExist(c => c.Id == id))
            {
                return BadRequest();
            }
            return View(await _contactService.GetEntity(c => c.Id == id));
        }

    }
}

