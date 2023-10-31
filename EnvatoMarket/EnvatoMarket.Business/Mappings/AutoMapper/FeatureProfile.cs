using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.FeatureVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class FeatureProfile:Profile
	{
		public FeatureProfile()
		{
			CreateMap<CreateFeatureVM, Feature>();
			CreateMap<UpdateFeatureVM, Feature>();
			CreateMap<Feature, UpdateFeatureVM>();
        }
	}
}

