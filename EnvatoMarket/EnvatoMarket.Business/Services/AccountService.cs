using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.AccountVM;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EnvatoMarket.Business.Services
{
	public class AccountService:IAccount
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountService(UserManager<AppUser> userManager , RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
		{
			_userManager = userManager;
			_roleManager = roleManager;
			_signInManager = signInManager;
		}

        public async Task<AppUser> GetUserByEmail(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<AppUser> GetUserById(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

       

        public async Task<bool> Register(RegisterVM registerVM)
        {
            try
            {
                if (await UserIsExist(u=>u.UserName==registerVM.UserName))
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

            }
            throw new NotImplementedException();
        }

        public async Task<bool> Remove(string id)
        {
            try
            {
                AppUser appUser =await _userManager.FindByIdAsync(id);
                if (appUser==null)
                {
                    return false;
                }
                await _userManager.DeleteAsync(appUser);
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public Task<bool> Update(string id, UpdateVM updateVM)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UserIsExist(Expression<Func<AppUser, bool>> predicate)
        {
            return await _userManager.Users.AnyAsync(predicate);
        }
    }
}

