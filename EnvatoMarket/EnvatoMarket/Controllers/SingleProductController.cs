using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.SingleProductVM;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stripe;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Controllers
{
    public class SingleProductController : Controller
    {
        // GET: /<controller>/
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;
        public SingleProductController(IProductService productService,UserManager<AppUser> userManager,ICommentService commentService)
        {
            _productService = productService;
            _userManager = userManager;
            _commentService = commentService;
        }
        public async Task<IActionResult> Index(string id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            else if (!await _productService.IsExist(p=>p.Id==id&&!p.IsDeleted))
            {
                return BadRequest();
            }
            ProductVM productVM = new();
            productVM.Product = await _productService.GetEntity(p => p.Id == id, "Category", "Brand", "ProductImages", "ProductTags.Tag", "Comments.AppUser");
            productVM.Products = await _productService.GetAll(p => !p.IsDeleted && p.IsAvailability, "ProductImages");
            if (User.Identity.IsAuthenticated)
            {
                productVM.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);
            }
            return View(productVM);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Comment(string userId,string productId,string comment,int rating)
        {
            if (comment==null)
            {
                return Redirect($"/SingleProduct/Index/{productId}");
            }
            Comment UserComment = new();
            AppUser appUser =await  _userManager.FindByIdAsync(userId);
            UserComment.Id = Guid.NewGuid().ToString();
            UserComment.AddedBy = appUser.UserName;
            UserComment.ProductId = productId;
            UserComment.Rating = rating;
            UserComment.UserId = userId;
            UserComment.Content = comment;
            var isSuccess = await _commentService.Create(UserComment);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return Redirect($"/SingleProduct/Index/{productId}");
        }
        public async Task<IActionResult> RemoveComment(string id,string productId)
        {
            if (id==null)
            {
                return BadRequest();
            }
            else if (!await _commentService.IsExist(c=>c.Id==id&&!c.IsDeleted))
            {
                return BadRequest();
            }
            await _commentService.Delete(id);
            
            return Redirect($"/SingleProduct/Index/{productId}"); 
        }
        public async Task<IActionResult> UpdateComment(string commentId,string productId,string content)
        {
            if (commentId==null||productId==null||content==null||!await _commentService.IsExist(c=>c.Id==commentId&&!c.IsDeleted))
            {
                return BadRequest();
            }
            Comment comment = await _commentService.GetEntity(c => c.Id == commentId);
            comment.Content = content;
            await _commentService.Update(comment);
            return Redirect($"/SingleProduct/Index/{productId}");
        }
    }
}

