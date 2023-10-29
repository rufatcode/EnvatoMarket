using System;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.HomeVM;
using EnvatoMarket.Business.ViewModels.Settings;
using EnvatoMarket.DAL;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnvatoMarket.ViewComponents
{
	public class HeaderViewComponent:ViewComponent
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;
		private readonly UserManager<AppUser> _userManager;
		private readonly ICategoryService _categoryService;
		public async Task<IViewComponentResult> InvokeAsync()
		{
			HeaderVM headerVM = new();
			headerVM.Settings = await _context.Settings.ToDictionaryAsync(s => s.Key,s=>s.Value) ;
			headerVM.Categories = await _categoryService.GetAll(c=>!c.IsDeleted, "Categories");
			if (User.Identity.IsAuthenticated)
			{
				AppUser appUser =await _userManager.FindByNameAsync(User.Identity.Name);
				headerVM.UserVM = _mapper.Map<UserVM>(appUser);
				
            }
			
			return View(await Task.FromResult(headerVM));
		}
		public HeaderViewComponent(AppDbContext context,IMapper mapper,UserManager<AppUser> userManager,ICategoryService categoryService)
		{
			_context = context;
			_mapper = mapper;
			_userManager = userManager;
			_categoryService = categoryService;
		}
	}
}

