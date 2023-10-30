using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class ProductTagRepository:Repository<ProductTag>,IProductTagRepository
	{
		public ProductTagRepository(AppDbContext context) : base(context)
        {
		}
	}
}

