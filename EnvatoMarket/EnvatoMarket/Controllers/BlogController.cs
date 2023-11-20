using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnvatoMarket.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Controllers
{
    public class BlogController : Controller
    {
        // GET: /<controller>/
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SingleBlog(string id)
        {
            return View();
        }
    }
}

