using System;
using Microsoft.AspNetCore.Http;

namespace EnvatoMarket.Business.ViewModels.SliderVM
{
	public class CreateSliderVM
	{
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public CreateSliderVM()
		{
		}
	}
}

