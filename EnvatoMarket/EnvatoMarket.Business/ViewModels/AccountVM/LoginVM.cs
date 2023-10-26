using System;
using System.ComponentModel.DataAnnotations;

namespace EnvatoMarket.Business.ViewModels.AccountVM
{
	public class LoginVM
	{
		public string EmailOrUserName { get; set; }
		[DataType(DataType.Password)]
		public string Password { get; set; }
		public bool IsRemember { get; set; }
		public LoginVM()
		{
		}
	}
}

