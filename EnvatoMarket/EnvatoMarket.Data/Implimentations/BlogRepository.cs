using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class BlogRepository:Repository<Blog>,IBlogRepository
	{
		public BlogRepository(AppDbContext context) : base(context)
        {
		}
	}
}

