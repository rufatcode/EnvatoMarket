using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EnvatoMarket.Business.ViewModels.BrandVM
{
	public class CreateBrandVM
	{
		[MinLength(5)]
        public string Name { get; set; }
		public IFormFile BrandImage { get; set; }
        public CreateBrandVM()
		{
		}
	}
}

