using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class CheckRepository:Repository<Check>,ICheckRepository
	{
		public CheckRepository(AppDbContext context) : base(context)
        {
		}
	}
}

