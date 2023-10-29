using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace EnvatoMarket.Business.ViewModels.CategoryVM
{
	public class CreateCategoryVM
	{
        public string CategoryName { get; set; }
        public IFormFile Image { get; set; }
        public bool IsMain { get; set; }
        public string? ParentId { get; set; }
        public CreateCategoryVM()
		{
		}
	}
}

