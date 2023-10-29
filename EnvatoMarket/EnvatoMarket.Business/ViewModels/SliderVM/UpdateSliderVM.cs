using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EnvatoMarket.Business.ViewModels.SliderVM
{
	public class UpdateSliderVM
	{
		[MinLength(5)]
        public string MainTitle { get; set; }
        [MinLength(5)]
        public string SubTitle { get; set; }
        [MinLength(10)]
        public string Description { get; set; }
        public IFormFile? Image { get; set; }
		public bool IsDeleted {  get; set; }
        public UpdateSliderVM()
		{
		}
	}
}

