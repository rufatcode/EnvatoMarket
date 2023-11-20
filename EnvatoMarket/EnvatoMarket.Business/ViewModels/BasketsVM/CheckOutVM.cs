using System;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Models;

namespace EnvatoMarket.Business.ViewModels.BasketsVM
{
	public class CheckOutVM
	{
		public AppUser appUser { get; set; }
		public List<BasketVM> basketVMs { get; set; }
		public List<Adress> Adresses { get; set; }
		public CheckOutVM()
		{
			basketVMs = new();
			Adresses = new();
		}
	}
}

