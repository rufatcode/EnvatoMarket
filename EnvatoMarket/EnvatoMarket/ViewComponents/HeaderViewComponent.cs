using System;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.HomeVM;
using EnvatoMarket.Business.ViewModels.Settings;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EnvatoMarket.ViewComponents
{
	public class HeaderViewComponent:ViewComponent
	{
		private readonly ISettingService _settingService;
		private readonly IMapper _mapper;
		private readonly UserManager<AppUser> _userManager;
		private readonly ICategoryService _categoryService;
        private readonly IBasketServices _basketServices;
		private readonly IProductService _productService;
        public async Task<IViewComponentResult> InvokeAsync()
		{
			HeaderVM headerVM = new();
			headerVM.Settings = await _settingService.GetSettingByKeyValue(s=>!s.IsDeleted);
			headerVM.Categories = await _categoryService.GetAll(c=>!c.IsDeleted, "Categories");
			if (User.Identity.IsAuthenticated)
			{
				AppUser appUser =await _userManager.FindByNameAsync(User.Identity.Name);
				headerVM.UserVM = _mapper.Map<UserVM>(appUser);
				
            }
            string basket = Request.Cookies["Basket"];
            if (basket == null)
            {
                ViewBag.ProductCount = 0;
                ViewBag.TotalPrice = 0;
            }
            else
            {
                List<ProductToBasket> productToBaskets = JsonConvert.DeserializeObject<List<ProductToBasket>>(basket);
                List<Product> products =await _productService.GetAll(p=>!p.IsDeleted);
                ViewBag.ProductCount = productToBaskets.Sum(p => p.ProductCount);
                ViewBag.TotalPrice = productToBaskets.Sum(pb => pb.ProductCount * products.Find(p => p.Id == pb.Id).Price);
                ViewBag.TotalTax = productToBaskets.Sum(pb => pb.ProductCount * products.Find(p => p.Id == pb.Id).Tax);
                ViewBag.Products =await  _basketServices.Show();
            }
			int n = 0;
            return View(await Task.FromResult(headerVM));
		}
		public HeaderViewComponent(IProductService productService,IBasketServices basketServices,ISettingService settingService,IMapper mapper,UserManager<AppUser> userManager,ICategoryService categoryService)
		{
			_basketServices = basketServices;
			_settingService = settingService;
			_mapper = mapper;
			_userManager = userManager;
			_categoryService = categoryService;
			_productService = productService;
		}
	}
}

