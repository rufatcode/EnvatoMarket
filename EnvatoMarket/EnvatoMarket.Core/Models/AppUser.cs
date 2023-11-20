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
        public List<Check> Checkes { get; set; }
        public List<Adress> Adresses { get; set; }
        public ICollection<ChatMessage> SentMessages { get; set; }
        public ICollection<ChatMessage> ReceivedMessages { get; set; }
        public ICollection<ChatImage> ReceivedImages { get; set; }
        public ICollection<ChatImage> SentImages { get; set; }
        public bool isOnline { get; set; }
        public string? ConnectionId { get; set; }
        public AppUser()
		{
		}
	}
}

