using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.TagVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class TagProfile:Profile
	{
		public TagProfile()
		{
			CreateMap<CreateTagVM, Tag>();
			CreateMap<UpdateTagVM, Tag>();
			CreateMap<Tag, UpdateTagVM>();
        }
	}
}

