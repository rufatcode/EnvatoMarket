using System;
using System.ComponentModel.DataAnnotations.Schema;
using EnvatoMarket.Models;

namespace EnvatoMarket.Core.Models
{
	public class Adress:BaseEntity
	{
		public string CompanyName { get; set; }
		public string Addres1 { get; set; }
		public string Addres2 { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }
		[ForeignKey(nameof(AppUser))]
		public string UserId { get; set; }
		public AppUser AppUser { get; set; }
		public Adress()
		{
		}
	}
}

