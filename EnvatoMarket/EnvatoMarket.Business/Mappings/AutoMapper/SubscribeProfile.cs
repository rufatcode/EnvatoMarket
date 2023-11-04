using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.SubscribeVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class SubscribeProfile:Profile
    {
		public SubscribeProfile()
		{
			CreateMap<UpdateSubscribeVM, Subscribe>();
			CreateMap<Subscribe, UpdateSubscribeVM>();
		}
	}
}

