using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class ProductImageRepository:Repository<ProductImage>,IProductImageRepository
	{
		public ProductImageRepository(AppDbContext context) : base(context)
        {
		}
	}
}

