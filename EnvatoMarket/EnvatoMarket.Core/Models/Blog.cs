using System;
namespace EnvatoMarket.Core.Models
{
	public class Blog:BaseEntity
	{
        public string Title { get; set; }
        public string Content { get; set; }
        public string BlogImage { get; set; }
        public Blog()
		{
		}
	}
}

