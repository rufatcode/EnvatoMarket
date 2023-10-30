using System;
using EnvatoMarket.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace EnvatoMarket.Business.ViewModels.ProductVM
{
	public class CreateProductVM
	{
        public IFormFile MainImage { get; set; }
        public IFormFile HoverImage { get; set; }
        public IFormFile[] ExtraImages { get; set; }
        [MinLength(5)]
        public string Name { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]
        public double Price { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]
        public double SalePercentage { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]
        public double Tax { get; set; }
        public bool IsAvailability { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]
        public int Count { get; set; }
        [MinLength(5)]
        public string Content { get; set; }
        public string CategoryId { get; set; }
        public string BrandId { get; set; }
        public List<string> TagIds { get; set; }
        public CreateProductVM()
		{
            TagIds = new();
		}
	}
}

