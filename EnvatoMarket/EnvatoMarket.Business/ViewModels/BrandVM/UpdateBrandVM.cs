using System;
using System.ComponentModel.DataAnnotations;

namespace EnvatoMarket.Business.ViewModels.BrandVM
{
	public class UpdateBrandVM
	{
        [MinLength(5)]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public UpdateBrandVM()
		{
		}
	}
}

