using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class ChatMessageRepository:Repository<ChatMessage>,IChatMessageRepository
	{
		public ChatMessageRepository(AppDbContext context) : base(context)
        {
		}
	}
}

