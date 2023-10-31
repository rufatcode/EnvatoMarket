using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class AuthorRepository:Repository<Author>,IAuthorRepository
	{
		public AuthorRepository(AppDbContext context) : base(context)
        {
		}
	}
}

