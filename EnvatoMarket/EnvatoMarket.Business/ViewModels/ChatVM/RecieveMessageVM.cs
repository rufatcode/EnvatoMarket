using System;
using EnvatoMarket.Models;

namespace EnvatoMarket.Business.ViewModels.ChatVM
{
	public class RecieveMessageVM
	{
        public string Message { get; set; }
        public string FromUserId { get; set; }
        public AppUser FromUser { get; set; }
        public string ToUserId { get; set; }
        public AppUser ToUser { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public RecieveMessageVM()
		{
		}
	}
}

