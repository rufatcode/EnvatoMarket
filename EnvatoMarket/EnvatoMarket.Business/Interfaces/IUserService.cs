using System;
using EnvatoMarket.Business.ViewModels.UsersVM;
using EnvatoMarket.Models;

namespace EnvatoMarket.Business.Interfaces
{
	public interface IUserService
	{
		public Task<Dictionary<string, bool>> GetExistRolesForUser(AppUser appUser, UserUpdateVM userUpdateVM);
    }
}

