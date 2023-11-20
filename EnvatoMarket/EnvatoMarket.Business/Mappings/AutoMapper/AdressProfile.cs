using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.AdressVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class AdressProfile:Profile
	{
		public AdressProfile()
		{
			CreateMap<CreateAdressVM, Adress>();
			CreateMap<UpdateAdressVM, Adress>();
			CreateMap<Adress, UpdateAdressVM>();
        }
	}
}

