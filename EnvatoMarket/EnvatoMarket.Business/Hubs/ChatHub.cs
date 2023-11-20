using System;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace EnvatoMarket.Business.Hubs
{
	public class ChatHub:Hub
	{
		private readonly UserManager<AppUser> _userManager;
		public ChatHub(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		public async Task SendMessageAsync(string message,string fromId,string toId)
		{
			await Clients.All.SendAsync("resieveMessage", message,fromId,toId);
		}
		public async Task UserTyping(string userId)
		{
			await Clients.All.SendAsync("recieveTyping", userId);
		}
        public  override  Task OnConnectedAsync()
        {
			if (Context.User.Identity.IsAuthenticated)
			{
                AppUser appUser = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;
                appUser.isOnline = true;
				appUser.ConnectionId = Context.ConnectionId;
				var resoult=_userManager.UpdateAsync(appUser).Result;
				Clients.All.SendAsync("OnConnect", appUser.Id);
            }
			
			
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception? exception)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser appUser = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;
                appUser.isOnline = false;
				appUser.ConnectionId = null ;
				var resoult = _userManager.UpdateAsync(appUser).Result;
                Clients.All.SendAsync("DisConnect", appUser.Id);
            }
            return base.OnDisconnectedAsync(exception);
        }
	}
}

