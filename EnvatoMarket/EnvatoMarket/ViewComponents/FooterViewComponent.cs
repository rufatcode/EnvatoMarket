using System;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnvatoMarket.ViewComponents
{
	public class FooterViewComponent:ViewComponent
	{
		private readonly ISettingService _settingService;
		public FooterViewComponent(ISettingService settingService)
		{
			_settingService = settingService;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _settingService.GetSettingByKeyValue(s=>!s.IsDeleted);
			return View(await Task.FromResult(data));
		}
	}
}

