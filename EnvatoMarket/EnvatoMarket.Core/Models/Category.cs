using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnvatoMarket.Core.Models
{
	public class Category:BaseEntity
	{
		public string CategoryName { get; set; }
		public string ImageUrl { get; set; }
		public bool IsMain { get; set; }
		[ForeignKey(nameof(Parent))]
		public string? ParentId { get; set; }
		public Category Parent { get; set; }
		public List<Category> Categories { get; set; }
		public Category()
		{
		}
	}
}

