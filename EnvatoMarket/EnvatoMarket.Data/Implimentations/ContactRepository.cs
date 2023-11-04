using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class ContactRepository:Repository<Contact>,IContactRepository
	{
		public ContactRepository(AppDbContext context) : base(context)
        {
		}
	}
}

