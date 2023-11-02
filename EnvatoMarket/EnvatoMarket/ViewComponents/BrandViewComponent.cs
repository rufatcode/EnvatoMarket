using System;
using EnvatoMarket.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EnvatoMarket.ViewComponents
{
	public class BrandViewComponent:ViewComponent
	{
		private readonly IBrandService  _brandService;
		public BrandViewComponent(IBrandService brandService)
		{
			_brandService = brandService;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _brandService.GetAll(b => !b.IsDeleted);
			return View(await Task.FromResult(data));
		}
	}
}

