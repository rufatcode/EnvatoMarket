using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class SubscribeRepository:Repository<Subscribe>, ISubscribeRepository
    {
		public SubscribeRepository(AppDbContext context) : base(context)
        {
		}
	}
}

