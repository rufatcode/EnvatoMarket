using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.Services;
using EnvatoMarket.Business.ViewModels.BrandVM;
using EnvatoMarket.Business.ViewModels.TagVM;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin,SupperAdmin")]
    public class TagController : Controller
    {
        // GET: /<controller>/
        private readonly ITagService _tagService;
        private readonly IMapper _mapper;
        public TagController(ITagService tagService, IMapper mapper)
        {
            _tagService = tagService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _tagService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult>Create(CreateTagVM createTagVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else if (await _tagService.IsExist(b => b.Name.ToLower() == createTagVM.Name.ToLower()))
            {
                ModelState.AddModelError("Name", "Name is exist");
                return View();
            }
            Tag tag = _mapper.Map<Tag>(createTagVM);
            tag.AddedBy = User.Identity.Name.ToString();
            tag.Id = Guid.NewGuid().ToString();

            bool isSuccess = await _tagService.Create(tag);
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
            bool isSuccess = await _tagService.Delete(id);
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
            else if (!await _tagService.IsExist(b => b.Id == id))
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            Tag tag = await _tagService.GetEntity(b => b.Id == id);

            return View(_mapper.Map<UpdateTagVM>(tag));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(string id, UpdateTagVM updateTagVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Tag tag = await _tagService.GetEntity(b => b.Id == id);
            if (await _tagService.IsExist(b => b.Name.ToLower() == updateTagVM.Name.ToLower() && updateTagVM.Name.ToLower() != tag.Name.ToLower()))
            {
                ModelState.AddModelError("Name", "This tag is exist");
                return View();
            }
            _mapper.Map(updateTagVM, tag);
            bool isSuccess = await _tagService.Update(tag);
            if (!isSuccess)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}

