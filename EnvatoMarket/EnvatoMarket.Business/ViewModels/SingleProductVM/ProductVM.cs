using System;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Models;

namespace EnvatoMarket.Business.ViewModels.SingleProductVM
{
	public class ProductVM
	{
		public List<Product> Products { get; set; }
		public Product Product { get; set; }
		public AppUser AppUser { get; set; }
		public ProductVM()
		{
			Products = new();
		}
	}
}

