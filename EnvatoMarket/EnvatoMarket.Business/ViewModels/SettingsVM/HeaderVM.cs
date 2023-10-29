using System;
using EnvatoMarket.Business.ViewModels.HomeVM;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Models;

namespace EnvatoMarket.Business.ViewModels.Settings
{
	public class HeaderVM
	{
		public UserVM UserVM { get; set; }
		public Dictionary<string, string> Settings { get; set; }
		public List<Category> Categories { get; set; }
		public HeaderVM()
		{
			Settings = new();
			Categories = new();
		}
	}
}

