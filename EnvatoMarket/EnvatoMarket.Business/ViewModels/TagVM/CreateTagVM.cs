using System;
using System.ComponentModel.DataAnnotations;

namespace EnvatoMarket.Business.ViewModels.TagVM
{
	public class CreateTagVM
	{
        [MinLength(5)]
        public string Name { get; set; }
        public CreateTagVM()
		{
		}
	}
}

