using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnvatoMarket.Core.Models
{
	public class Product:BaseEntity
	{
		public string Name { get; set; }
		[Range(0,int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public double Price { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public double SalePercentage { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int StarsCount { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public double Tax { get; set; }
		public bool IsAvailability { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Count { get; set; }
		public string Content { get; set; }
		public string ProductCode { get; set; }
		[ForeignKey(nameof(Category))]
		public string CategoryId { get; set; }
		public Category Category { get; set; }
		[ForeignKey(nameof(Brand))]
		public string BrandId { get; set; }
		public Brand Brand { get; set; }
		public List<ProductImage> ProductImages { get; set; }
		public List<ProductTag> ProductTags { get; set; }
		public List<Comment> Comments { get; set; }
        public Product()
		{
			ProductImages = new();
			ProductTags = new();

        }
	}
}

