using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.CategoryVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class CategoryProfile:Profile
	{
		public CategoryProfile()
		{
			CreateMap<CreateCategoryVM, Category>();
			CreateMap<UpdateCategoryVM, Category>();
			CreateMap<Category, UpdateCategoryVM>();
		}
	}
}

