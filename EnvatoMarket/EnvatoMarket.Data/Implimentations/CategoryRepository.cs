using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class CategoryRepository:Repository<Category>,ICategoryRepository
	{
		public CategoryRepository(AppDbContext context):base(context)
		{
		}
	}
}

