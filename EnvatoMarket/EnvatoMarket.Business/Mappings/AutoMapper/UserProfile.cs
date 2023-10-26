using System;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.UsersVM;
using EnvatoMarket.Models;

namespace EnvatoMarket.Business.Mappings.AutoMapper
{
	public class UserProfile:Profile
	{

		public UserProfile()
		{
			CreateMap<AppUser, GetUserVM>();
			CreateMap<AppUser, UserUpdateVM>();
		}
	}
}

