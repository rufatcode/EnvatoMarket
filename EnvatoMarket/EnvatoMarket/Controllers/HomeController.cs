using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<AppUser>  signInManager;
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}

