using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.BlogVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class BlogProfile:Profile
	{
		public BlogProfile()
		{
			CreateMap<CreateBlogVM, Blog>();
			CreateMap<UpdateBlogVM, Blog>();
            CreateMap<Blog, UpdateBlogVM>();

        }
    }
}

