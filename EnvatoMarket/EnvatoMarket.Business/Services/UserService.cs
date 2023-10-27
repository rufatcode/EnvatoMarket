using System;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.UsersVM;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;

namespace EnvatoMarket.Business.Services
{
	public class UserService:IUserService
	{
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserService(UserManager<AppUser> userManager, IMapper mapper, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
        }


        public async Task<Dictionary<string, bool>> GetExistRolesForUser(AppUser appUser,UserUpdateVM userUpdateVM)
        {
            
            
            List<IdentityRole> roles = _roleManager.Roles.ToList();
            Dictionary<string, bool> existRoles = new();
            foreach (var role in roles)
            {
                if (userUpdateVM.Roles.Any(r => r.ToLower() == role.Name.ToLower()))
                {
                    existRoles.Add(role.Name, true);
                }
                else
                {
                    existRoles.Add(role.Name, false);
                }
            }
            return existRoles;
        }
    }
}

