using System;
namespace EnvatoMarket.Core.Models
{
	public class Slider:BaseEntity
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public Slider()
		{
		}
	}
}

