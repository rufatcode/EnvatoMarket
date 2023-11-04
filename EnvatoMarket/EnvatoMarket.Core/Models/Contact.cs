using System;
namespace EnvatoMarket.Core.Models
{
	public class Contact:BaseEntity
	{
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
		public string? Replay { get; set; }
		public Contact()
		{
		}
	}
}

