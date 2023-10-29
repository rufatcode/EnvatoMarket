using System;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.ViewModels.HomeVM
{
	public class HomeIndexVM
	{
		public List<Slider> Sliders { get; set; }
		public List<Category> Categories { get; set; }
		public HomeIndexVM()
		{
			Sliders = new();
			Categories = new();
		}
	}
}

