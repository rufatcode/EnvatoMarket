using System;
using EnvatoMarket.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EnvatoMarket.ViewComponents
{
	public class FeatureViewComponent:ViewComponent
	{
		private readonly IFeatureService _featureService;
		public FeatureViewComponent(IFeatureService featureService)
		{
			_featureService = featureService;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data= await _featureService.GetAll(f => !f.IsDeleted);
            return View(await Task.FromResult(data));
		}
	}
}

