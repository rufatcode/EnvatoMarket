using System;
namespace EnvatoMarket.Core.Models
{
	public class Tag:BaseEntity
	{
        public string Name { get; set; }
		public List<ProductTag> ProductTags { get; set; }
        public Tag()
		{
		}
	}
}

