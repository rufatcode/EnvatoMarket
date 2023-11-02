using System;
using System.ComponentModel.DataAnnotations.Schema;
using EnvatoMarket.Models;

namespace EnvatoMarket.Core.Models
{
	public class Comment:BaseEntity
	{
		[ForeignKey(nameof(Product))]
		public string ProductId { get; set; }
		public Product Product { get; set; }
		[ForeignKey(nameof(AppUser))]
		public string UserId { get; set; }
		public AppUser AppUser { get; set; }
		public int Rating { get; set; }
		public string Content { get; set; }
		public Comment()
		{
		}
	}
}

