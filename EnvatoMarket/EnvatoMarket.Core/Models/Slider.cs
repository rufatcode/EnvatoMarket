using System;
namespace EnvatoMarket.Core.Models
{
	public class Slider:BaseEntity
	{
		public string MainTitle { get; set; }
		public string SubTitle { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public Slider()
		{
		}
	}
}

