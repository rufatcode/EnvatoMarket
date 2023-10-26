using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.HomeVM;
using EnvatoMarket.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class HomeProfile:Profile
	{
		public HomeProfile()
		{
			CreateMap<AppUser, UserVM>();
		}
	}
}

