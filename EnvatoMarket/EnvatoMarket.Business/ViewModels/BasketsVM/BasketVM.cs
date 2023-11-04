using System;
namespace EnvatoMarket.Business.ViewModels.BasketsVM
{
	public class BasketVM
	{
        public string Id { get; set; }
        public int ProductCount { get; set; }
        public string Name { get; set; }
        public string ImgSrc { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public BasketVM()
		{
		}
	}
}

