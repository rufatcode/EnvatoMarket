using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;

namespace EnvatoMarket.Data.Implimentations
{
	public class FeatureRepository:Repository<Feature>,IFeatureRepository
	{
		public FeatureRepository(AppDbContext context) : base(context)
        {
		}
	}
}

