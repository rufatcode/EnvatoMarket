using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnvatoMarket.Core.Models
{
	public class ProductImage:BaseEntity
	{
		[ForeignKey(nameof(Product))]
		public string ProductId { get; set; }
		public Product Product { get; set; }
		public bool IsMain { get; set; }
		public bool IsHover { get; set; }
		public string ImageUrl { get; set; }
		public ProductImage()
		{
		}
	}
}

