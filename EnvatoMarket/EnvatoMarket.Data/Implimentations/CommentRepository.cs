using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class CommentRepository:Repository<Comment>,ICommentRepository
	{
		public CommentRepository(AppDbContext context) : base(context)
        {
		}
	}
}

