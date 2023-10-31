using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EnvatoMarket.Business.ViewModels.BrandVM
{
	public class UpdateBrandVM
	{
        [MinLength(5)]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public IFormFile? BrandImage { get; set; }
        public UpdateBrandVM()
		{
		}
	}
}

