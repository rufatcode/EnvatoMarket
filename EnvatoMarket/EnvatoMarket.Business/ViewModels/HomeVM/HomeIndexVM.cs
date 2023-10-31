using System;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.ViewModels.HomeVM
{
	public class HomeIndexVM
	{
		public List<Slider> Sliders { get; set; }
		public List<Category> Categories { get; set; }
		public List<Product> Products { get; set; }
		public List<Author> Authors { get; set; }
		public List<Blog> Blogs { get; set; }
		public List<Brand> Brands { get; set; }
        public HomeIndexVM()
		{
			Sliders = new();
			Categories = new();
			Products = new();
			Authors = new();
			Blogs = new();
			Brands = new();
		}
	}
}

