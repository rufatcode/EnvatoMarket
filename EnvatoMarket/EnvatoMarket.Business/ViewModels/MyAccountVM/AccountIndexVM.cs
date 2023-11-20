using System;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.ViewModels.MyAccountVM
{
	public class AccountIndexVM
	{
		public List<Adress> Adresses { get; set; }
		public AccountIndexVM()
		{
			Adresses = new();
		}
	}
}

