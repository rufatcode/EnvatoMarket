using System;
namespace EnvatoMarket.Core.Models
{
	public class Author:BaseEntity
	{
		public string Name { get; set; }
		public string About { get; set; }
		public string ProfileImage { get; set; }
		public string Email { get; set; }
		public Author()
		{
		}
	}
}

