using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.UsersVM;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin,SupperAdmin")]
    public class UserController : Controller
    {
        // GET: /<controller>/
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUserService _userService;
        public UserController(UserManager<AppUser> userManager,IMapper mapper,RoleManager<IdentityRole> roleManager,IUserService userService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
            _userService = userService;
        }
        public async Task<IActionResult> Pagination(int skip, int take = 4)
        {
            List<AppUser> users = await _userManager.Users.ToListAsync();
            List<GetUserVM> userVMs = _mapper.Map<List<AppUser>, List<GetUserVM>>(users);
            for (int i = 0; i < users.Count; i++)
            {
                userVMs[i].Roles = await _userManager.GetRolesAsync(users[i]);
            }
            return PartialView("_UserPartial", userVMs.Skip(skip).Take(4).ToList());
        }
        public async Task<IActionResult>Index()
        {
            List<AppUser> users = await _userManager.Users.ToListAsync();
            ViewBag.ProductCount = users.Count;
            List<GetUserVM> userVMs = _mapper.Map<List<AppUser>,List<GetUserVM>>(users);
            for (int i = 0; i < users.Count; i++)
            {
                userVMs[i].Roles=await _userManager.GetRolesAsync(users[i]);
            }
            return View(userVMs.Take(4).ToList());
        }
        [Authorize(Roles = "SupperAdmin")]
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
            appUser.Removed = DateTime.Now;
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
        [Authorize(Roles = "SupperAdmin")] 
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
            userUpdateVM.Roles = await _userManager.GetRolesAsync(appUser);
            ViewBag.Roles =await _userService.GetExistRolesForUser(appUser,userUpdateVM);
            return View(userUpdateVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(string id,UserUpdateVM userUpdateVM)
        {
            AppUser appUser = await _userManager.FindByIdAsync(id);
            UserUpdateVM existUserUpdateVM = _mapper.Map<UserUpdateVM>(appUser);
            existUserUpdateVM.Roles = await _userManager.GetRolesAsync(appUser);
            ViewBag.Roles = await _userService.GetExistRolesForUser(appUser, existUserUpdateVM);
            if (!ModelState.IsValid)
            {
                return View();
            }
            else if (userUpdateVM.Roles==null||userUpdateVM.Roles.Count==0)
            {
                ModelState.AddModelError("Roles", "Roles Must not be Null");
                return View();
            }
            _mapper.Map(userUpdateVM, appUser);
            if (userUpdateVM.IsDeleted)
            {
                IList<string> roles = await _userManager.GetRolesAsync(appUser);

                foreach (var role in roles)
                {
                    if (role == "Admin" || role == "SupperAdmin")
                    {
                        return BadRequest();
                    }
                }
            }
            else
            {
                appUser.Removed = null;
            }
            
            await _userManager.RemoveFromRolesAsync(appUser, existUserUpdateVM.Roles);
           
            appUser.Updated = DateTime.Now;
            await _userManager.AddToRolesAsync(appUser, userUpdateVM.Roles);
            IdentityResult result= await _userManager.UpdateAsync(appUser);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            return RedirectToAction("Index");
        }

    }
}

