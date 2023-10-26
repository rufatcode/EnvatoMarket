﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EnvatoMarket.Business.ViewModels.AccountVM
{
	public class RegisterVM
	{
		[MinLength(5)]
		public string FullName { get; set; }
		public string UserName { get; set; }
		[DataType(DataType.EmailAddress),EmailAddress]
		public string Email { get; set; }
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[DataType(DataType.Password),Compare(nameof(ConfirmPassword))]
		public string ConfirmPassword { get; set; }
		public RegisterVM()
		{
		}
	}
}

