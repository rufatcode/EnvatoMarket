using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.ViewModels.AdressVM;
using EnvatoMarket.Business.ViewModels.MyAccountVM;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Controllers
{
    [Authorize]
    public class MyAccountController : Controller
    {
        // GET: /<controller>/
        private readonly IAdressSrevice _adressService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        public MyAccountController(IAdressSrevice adressSrevice,IMapper mapper,UserManager<AppUser> userManager)
        {
            _adressService = adressSrevice;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            AccountIndexVM accountIndexVM = new();
            accountIndexVM.Adresses = await _adressService.GetAll(a=>!a.IsDeleted&&a.AppUser.UserName==User.Identity.Name, "AppUser");
            return View(accountIndexVM);
        }
        public async Task<IActionResult> CreateAdress()
        {
            
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        
        public async Task<IActionResult> CreateAdress(CreateAdressVM createAdressVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Adress adress = _mapper.Map<Adress>(createAdressVM);
            adress.Id = Guid.NewGuid().ToString();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            adress.UserId = user.Id;
            adress.AddedBy = User.Identity.Name.ToString();
            bool isSuccess = await _adressService.Create(adress);
            if (!isSuccess)
            {
                ModelState.AddModelError("","Something went wrong");
                return View();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult>Delete(string id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            bool isSuccess=await _adressService.Delete(id);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateAdress(string id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            else if (!await _adressService.IsExist(a=>a.Id==id&&!a.IsDeleted))
            {
                return BadRequest();
            }
            UpdateAdressVM updateAdressVM = _mapper.Map<UpdateAdressVM>(await _adressService.GetEntity(a => a.Id == id));
            return View(updateAdressVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> UpdateAdress(string id,UpdateAdressVM updateAdressVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Adress adress = await _adressService.GetEntity(a => a.Id == id);
            adress=_mapper.Map(updateAdressVM,adress);
            bool isSuccess = await _adressService.Update(adress);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction("Index");
        }
    }
}

