using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class BrandRepository:Repository<Brand>,IBrandRepository
	{
		public BrandRepository(AppDbContext context):base(context)
		{
		}
	}
}

