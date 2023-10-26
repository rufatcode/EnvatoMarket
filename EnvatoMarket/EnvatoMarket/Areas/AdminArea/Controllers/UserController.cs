using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.ViewModels.UsersVM;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class UserController : Controller
    {
        // GET: /<controller>/
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserController(UserManager<AppUser> userManager,IMapper mapper,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
        }
        public async Task<IActionResult>Index()
        {
            List<AppUser> users = await _userManager.Users.ToListAsync();
            List<GetUserVM> userVMs = _mapper.Map<List<AppUser>,List<GetUserVM>>(users);
            for (int i = 0; i < users.Count; i++)
            {
                userVMs[i].Roles=await _userManager.GetRolesAsync(users[i]);
            }
            return View(userVMs);
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id==null)
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            AppUser appUser = await _userManager.FindByIdAsync(id);
            if (appUser==null)
            {
                return BadRequest();
            }
            IList<string> roles =await _userManager.GetRolesAsync(appUser);
            foreach (var role in roles)
            {
                if (role=="Admin"||role=="SupperAdmin")
                {
                    return BadRequest();
                }
            }
            appUser.IsDeleted = true;
            await _userManager.UpdateAsync(appUser);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(string id)
        {
            if (id==null)
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            AppUser appUser =await _userManager.FindByIdAsync(id);
            if (appUser==null)
            {
                return BadRequest();
            }
            GetUserVM userVM = _mapper.Map<GetUserVM>(appUser);
            return View(userVM);
        }
        public async Task<IActionResult> Update(string id)
        {
            if (id==null)
            {
                return Redirect("/Account/TokenIsNotValid");
            }
            AppUser appUser =await _userManager.FindByIdAsync(id);
            if (appUser==null)
            {
                return BadRequest();
            }
            UserUpdateVM userUpdateVM = _mapper.Map<UserUpdateVM>(appUser);
            userUpdateVM.Roles =await _userManager.GetRolesAsync(appUser);
            ViewBag.Roles =await _roleManager.Roles.ToListAsync();
            return View(userUpdateVM);
        }
    }
}

