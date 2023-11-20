using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Features;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.Services;
using EnvatoMarket.Business.ViewModels.AuthorVM;
using EnvatoMarket.Business.ViewModels.BlogVM;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin,SupperAdmin")]
    public class BlogController : Controller
    {
        // GET: /<controller>/
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        public BlogController(IMapper mapper, IBlogService blogService, IFileService fileService)
        {
            _mapper = mapper;
            _blogService = blogService;
            _fileService = fileService;
        }
        public async Task<IActionResult> Pagination(int skip, int take = 4)
        {
            var data = await _blogService.GetAll();
            return PartialView("_BlogPartial", data.Skip(skip).Take(take).ToList());
        }
        public async Task<IActionResult> Index()
        {
            var data = await _blogService.GetAll();
            ViewBag.ProductCount = data.Count;
            return View(data.Take(4).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CreateBlogVM createBlogVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else if (!_fileService.IsImage(createBlogVM.Image))
            {
                ModelState.AddModelError("Image", "Please enter only Image");
                return View();
            }
            else if (!_fileService.IsLengthSuit(createBlogVM.Image, 1000))
            {
                ModelState.AddModelError("Image", "Length is greater than 1kb");
                return View();
            }
            Blog blog = _mapper.Map<Blog>(createBlogVM);
            blog.AddedBy = User.Identity.Name.ToString();
            blog.BlogImage = _fileService.CreateImage(createBlogVM.Image);
            blog.Id = Guid.NewGuid().ToString();
            bool isSuccess = await _blogService.Create(blog);
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
            bool resoult = await _blogService.Delete(id);
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
            else if (!await _blogService.IsExist(b => b.Id == id))
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            Blog blog = await _blogService.GetEntity(b => b.Id == id);

            return View(blog);
        }
        [Authorize(Roles = "SupperAdmin")]
        public async Task<IActionResult> Update(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else if (!await _blogService.IsExist(b => b.Id == id))
            {
                return BadRequest();
            }
            Blog blog = await _blogService.GetEntity(b => b.Id == id);
            UpdateBlogVM updateBlogVM = _mapper.Map<UpdateBlogVM>(blog);
            return View(updateBlogVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(string id, UpdateBlogVM updateBlogVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Blog blog = await _blogService.GetEntity(b => b.Id == id);

            if (updateBlogVM.Image != null)
            {
                if (!_fileService.IsImage(updateBlogVM.Image))
                {
                    ModelState.AddModelError("Image", "Upload Only Image");
                    return View();
                }
                else if (!_fileService.IsLengthSuit(updateBlogVM.Image, 1000))
                {
                    ModelState.AddModelError("Image", "File length must be smaller than 1 kb");
                    return View();
                }
                if (blog.BlogImage!=null)
                {
                    _fileService.DeleteImage(blog.BlogImage);
                }
                blog.BlogImage = _fileService.CreateImage(updateBlogVM.Image);
               
            }
            _mapper.Map(updateBlogVM, blog);
            bool resoult = await _blogService.Update(blog);
            if (!resoult)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }

            return RedirectToAction("Index");
        }
    }
}

