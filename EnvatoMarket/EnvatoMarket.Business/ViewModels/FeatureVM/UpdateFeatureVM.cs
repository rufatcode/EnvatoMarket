using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace EnvatoMarket.Business.ViewModels.FeatureVM
{
	public class UpdateFeatureVM
	{
        public IFormFile? Image { get; set; }
        [MinLength(5)]
        public string Title { get; set; }
        [MinLength(8)]
        public string Content { get; set; }
        public bool IsDeleted { get; set; }
        public UpdateFeatureVM()
		{
		}
	}
}

