using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Features;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.Services;
using EnvatoMarket.Business.ViewModels.AuthorVM;
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
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        public AuthorController(IMapper mapper,IAuthorService authorService,IFileService fileService)
        {
            _mapper = mapper;
            _authorService = authorService;
            _fileService = fileService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _authorService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult>Create(CreateAuthorVM createAuthorVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else if (!_fileService.IsImage(createAuthorVM.Image))
            {
                ModelState.AddModelError("Image", "Please enter only Image");
                return View();
            }
            else if (!_fileService.IsLengthSuit(createAuthorVM.Image, 1000))
            {
                ModelState.AddModelError("Image", "Length is greater than 1kb");
                return View();
            }
            Author author = _mapper.Map<Author>(createAuthorVM);
            author.AddedBy = User.Identity.Name.ToString();
            author.ProfileImage = _fileService.CreateImage(createAuthorVM.Image);
            author.Id = Guid.NewGuid().ToString();
            bool isSuccess = await _authorService.Create(author);
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
            bool resoult = await _authorService.Delete(id);
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
            else if (!await _authorService.IsExist(c => c.Id == id))
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            Author author = await _authorService.GetEntity(a => a.Id == id);

            return View(author);
        }
        [Authorize(Roles = "SupperAdmin")]
        public async Task<IActionResult> Update(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else if (!await _authorService.IsExist(a => a.Id == id))
            {
                return BadRequest();
            }
            Author author = await _authorService.GetEntity(c => c.Id == id);
            UpdateAuthorVM updateAuthorVM = _mapper.Map<UpdateAuthorVM>(author);
            return View(updateAuthorVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(string id, UpdateAuthorVM updateAuthorVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Author author = await _authorService.GetEntity(c => c.Id == id);
            
            if (await _authorService.IsExist(a => a.Name == updateAuthorVM.Name && updateAuthorVM.Name != author.Name))
            {
                ModelState.AddModelError("Name", "This Category is exist");
                return View();
            }
            if (updateAuthorVM.Image != null)
            {
                if (!_fileService.IsImage(updateAuthorVM.Image))
                {
                    ModelState.AddModelError("Image", "Upload Only Image");
                    return View();
                }
                else if (!_fileService.IsLengthSuit(updateAuthorVM.Image, 1000))
                {
                    ModelState.AddModelError("Image", "File length must be smaller than 1 kb");
                    return View();
                }
               
                author.ProfileImage = _fileService.CreateImage(updateAuthorVM.Image);
                _fileService.DeleteImage(author.ProfileImage);
            }
            _mapper.Map(updateAuthorVM, author);
            bool resoult = await _authorService.Update(author);
            if (!resoult)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }

            return RedirectToAction("Index");
        }
    }
}

