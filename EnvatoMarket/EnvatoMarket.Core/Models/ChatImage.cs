using System;
using EnvatoMarket.Models;

namespace EnvatoMarket.Core.Models
{
	public class ChatImage:BaseEntity
	{
        public string ImageUrl { get; set; }
        public string FromUserId { get; set; }
        public AppUser FromUser { get; set; }
        public string ToUserId { get; set; }
        public AppUser ToUser { get; set; }
        public bool IsSeen { get; set; }
        public ChatImage()
		{
		}
	}
}

