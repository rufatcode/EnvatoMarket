using System;
using Microsoft.AspNetCore.Identity;

namespace EnvatoMarket.Models
{
	public class AppUser:IdentityUser
	{
		public string FullName { get; set; }
		public string? ProfileImageUrl { get; set; }
		public bool IsActive { get; set; }
		public AppUser()
		{
		}
	}
}

