using System;
using System.ComponentModel.DataAnnotations;

namespace EnvatoMarket.Business.ViewModels.TagVM
{
	public class UpdateTagVM
	{
        [MinLength(5)]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public UpdateTagVM()
		{
		}
	}
}

