using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.BrandVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class BrandProfile:Profile
	{
		public BrandProfile()
		{
			CreateMap<CreateBrandVM, Brand>();
			CreateMap<UpdateBrandVM, Brand>();
			CreateMap<Brand, UpdateBrandVM>();
        }
	}
}

