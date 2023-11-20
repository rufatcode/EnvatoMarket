using System;
using EnvatoMarket.Models;

namespace EnvatoMarket.Business.ViewModels.ChatVM
{
	public class MessagePartialVM
	{
        public RecieveMessageVM Message { get; set; }
        public AppUser AppUser { get; set; }
        public string UserId { get; set; }
        public MessagePartialVM()
		{
		}
	}
}

