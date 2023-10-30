using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class ProductRepository:Repository<Product>,IProductRepository
	{
		public ProductRepository(AppDbContext context) : base(context)
        {
		}
	}
}

