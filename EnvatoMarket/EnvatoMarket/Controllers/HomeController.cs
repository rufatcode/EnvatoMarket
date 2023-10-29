using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.HomeVM;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly ICategoryService _categoryService;
        public HomeController(ISliderService sliderService,ICategoryService categoryService)
        {
            _sliderService = sliderService;
            _categoryService = categoryService;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            HomeIndexVM homeIndexVM = new();
            homeIndexVM.Sliders = await _sliderService.GetAll();
            homeIndexVM.Categories = await _categoryService.GetAll(c=>!c.IsDeleted);
            return View(homeIndexVM);
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}

