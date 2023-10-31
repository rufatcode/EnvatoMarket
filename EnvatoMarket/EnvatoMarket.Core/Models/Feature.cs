using System;
namespace EnvatoMarket.Core.Models
{
	public class Feature:BaseEntity
	{
		public string ImageUrl { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public Feature()
		{
		}
	}
}

