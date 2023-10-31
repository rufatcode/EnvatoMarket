using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EnvatoMarket.Business.ViewModels.FeatureVM
{
	public class CreateFeatureVM
	{
        public IFormFile Image { get; set; }
		[MinLength(5)]
        public string Title { get; set; }
        [MinLength(8)]
        public string Content { get; set; }
        public CreateFeatureVM()
		{
		}
	}
}

