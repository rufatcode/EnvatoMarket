using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.AuthorVM;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class AuthorProfile:Profile
	{
		public AuthorProfile()
		{
			CreateMap<CreateAuthorVM, Author>();
			CreateMap<UpdateAuthorVM, Author>();
			CreateMap<Author, UpdateAuthorVM>();
		}
	}
}

