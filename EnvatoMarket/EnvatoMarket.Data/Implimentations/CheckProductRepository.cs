using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class CheckProductRepository:Repository<CheckProduct>,ICheckProductRepository
	{
		public CheckProductRepository(AppDbContext context) : base(context)
        {
		}
	}
}

