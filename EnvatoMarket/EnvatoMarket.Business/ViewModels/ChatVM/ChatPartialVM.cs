using System;
using EnvatoMarket.Models;

namespace EnvatoMarket.Business.ViewModels.ChatVM
{
	public class ChatPartialVM
	{
		public List<RecieveMessageVM> Messages { get; set; }
		public AppUser AppUser { get; set; }
		public int TotalMessage { get; set; }
		public AppUser FromUser { get; set; }
		public AppUser ToUser { get; set; }
		public ChatPartialVM()
		{
			Messages = new();
		}
	}
}

