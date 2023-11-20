using System;
using EnvatoMarket.Models;

namespace EnvatoMarket.Business.ViewModels.ChatVM
{
	public class SendMessageVM
	{
        public string Message { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public SendMessageVM()
		{
		}
	}
}

