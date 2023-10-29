using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class TagRepository:Repository<Tag>,ITagRepository
	{
		public TagRepository(AppDbContext context):base(context)
		{
		}
	}
}

