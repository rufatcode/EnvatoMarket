using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnvatoMarket.Core.Models
{
	public class ProductTag:BaseEntity
	{
		[ForeignKey(nameof(Tag))]
		public string TagId { get; set; }
		public Tag Tag { get; set; }
        [ForeignKey(nameof(Product))]
        public string ProductId { get; set; }
		public Product Product { get; set; }
		public ProductTag()
		{
		}
	}
}

