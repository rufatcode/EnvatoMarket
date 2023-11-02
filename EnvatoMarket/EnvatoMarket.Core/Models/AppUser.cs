using System;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace EnvatoMarket.Models
{
	public class AppUser:IdentityUser
	{
		public string FullName { get; set; }
		public string? ProfileImageUrl { get; set; }
		public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Removed { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public bool IsDeleted { get; set; }
		public List<Comment> Comments { get; set; }
        public AppUser()
		{
		}
	}
}

