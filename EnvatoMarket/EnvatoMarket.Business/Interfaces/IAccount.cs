using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.ViewModels.AccountVM;
using EnvatoMarket.Models;

namespace EnvatoMarket.Business.Interfaces
{
	public interface IAccount
	{
		public Task<bool> Register(RegisterVM registerVM);
		public Task<AppUser> GetUserById(string id);
		public Task<bool> UserIsExist(Expression<Func<AppUser,bool>> predicate);
		public Task<AppUser> GetUserByEmail(string email);
		public Task<bool> Remove(string id);
		public Task<bool> Update(string id,UpdateVM updateVM);
	}
}

