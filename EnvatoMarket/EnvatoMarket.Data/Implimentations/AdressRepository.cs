using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class AdressRepository:Repository<Adress>,IAdressRepository
	{
		public AdressRepository(AppDbContext context) : base(context)
        {
		}
	}
}

