using System;
using Microsoft.AspNetCore.Http;

namespace EnvatoMarket.Business.ViewModels.CategoryVM
{
	public class UpdateCategoryVM
	{
        public string CategoryName { get; set; }
        public IFormFile? Image { get; set; }
        public bool IsMain { get; set; }
        public string? ParentId { get; set; }
        public bool IsDeleted { get; set; }
        public UpdateCategoryVM()
		{
		}
	}
}

