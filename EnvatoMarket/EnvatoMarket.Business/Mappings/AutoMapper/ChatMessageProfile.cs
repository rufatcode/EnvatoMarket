using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.ChatVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class ChatMessageProfile:Profile
	{
		public ChatMessageProfile()
		{
			CreateMap<SendMessageVM, ChatMessage>();
			CreateMap<ChatMessage, RecieveMessageVM>();
			CreateMap<ChatMessage, UpdateMessageVM>().ReverseMap();
        }
	}
}

