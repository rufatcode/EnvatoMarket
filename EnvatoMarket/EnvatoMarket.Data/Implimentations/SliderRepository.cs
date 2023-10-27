using System;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.DAL;
using Microsoft.EntityFrameworkCore;

namespace EnvatoMarket.Data.Implimentations
{
	public class SliderRepository:Repository<Slider>,ISliderRepository
	{
        public SliderRepository(AppDbContext context):base(context)
		{
		}
	}
}

