using System;
using System.ComponentModel.DataAnnotations;

namespace EnvatoMarket.Business.ViewModels.BrandVM
{
	public class CreateBrandVM
	{
		[MinLength(5)]
        public string Name { get; set; }
        public CreateBrandVM()
		{
		}
	}
}

