using System;
using EnvatoMarket.Models;

namespace EnvatoMarket.Business.ViewModels.ChatVM
{
	public class ChatIndexVM
	{
		public List<AppUser> AppUser { get; set; }
		public AppUser MyProfile { get; set; }
		public AppUser SupperAdmin { get; set; }
		public List<SendMessageVM> SendMessageVMs { get; set; }
		public List<RecieveMessageVM> RecieveMessageVMs { get; set; }
		public ChatIndexVM()
		{
			AppUser = new();
			RecieveMessageVMs = new();
			SendMessageVMs = new();
		}
	}
}

