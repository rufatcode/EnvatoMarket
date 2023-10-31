using System;
namespace EnvatoMarket.Core.Models
{
	public class Brand:BaseEntity
	{
		public string ImageUrl { get; set; }
		public string Name { get; set; }
		public List<Product> Products { get; set; }
		public Brand()
		{
		}
	}
}

