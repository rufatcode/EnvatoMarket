using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using EnvatoMarket.Business.ViewModels.AccountVM;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else if (await _userManager.Users.AnyAsync(u=>u.UserName.ToLower()==registerVM.UserName.ToLower()))
            {
                ModelState.AddModelError("UserName", "UserName must be unique for every users");
                return View();
            }
            AppUser appUser = new();
            appUser.Email = registerVM.Email;
            appUser.FullName = registerVM.FullName;
            appUser.UserName = registerVM.UserName;
            appUser.Created = DateTime.Now;
            appUser.AddedBy = "System";
            appUser.IsActive = true;
            IdentityResult resoult =await _userManager.CreateAsync(appUser, registerVM.Password);
            if (!resoult.Succeeded)
            {
                foreach (var error in resoult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            string token =await _userManager.GenerateEmailConfirmationTokenAsync(appUser);
            string link = Url.Action(nameof(VerifyEmail), "Account", new { VerifyEmail = appUser.Email, token }, Request.Scheme, Request.Host.ToString());
            MailMessage mailMessage = new();
            mailMessage.From = new MailAddress("rufatri@code.edu.az");
            mailMessage.To.Add(new MailAddress(appUser.Email, "Allup"));
            mailMessage.Subject = "verify email";
            string verificationMessageBody = string.Empty;
            using (StreamReader fileStream = new StreamReader("wwwroot/Verification/VerificationEmail.html"))
            {
                verificationMessageBody = await fileStream.ReadToEndAsync();
            }
            verificationMessageBody.Replace("{{link}}", link);
            verificationMessageBody.Replace("{{userName}}", appUser.UserName);
            mailMessage.Body = verificationMessageBody;
            mailMessage.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new NetworkCredential("rufatri@code.edu.az", "bazi tvxk bnta hymo");
            smtp.Send(mailMessage);
            return RedirectToAction("Login", "Account");
        }
        public async Task<IActionResult> VerifyEmail(string VerifyEmail,string token)
        {
            /*
            AppUser appUser =await _userManager.FindByEmailAsync(VerifyEmail);
            if (appUser==null)
            {
                return NotFound();
            }
            var IsExpired = await _userManager.VerifyUserTokenAsync(appUser, _userManager.Options.Tokens.EmailConfirmationTokenProvider, "VerifyEmail", token);
            if (!IsExpired)
            {
                return RedirectToAction("TokenIsNotValid");
            }
            */
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> VerifyEmail(string VerifyEmail, string token,int id)
        {
            AppUser appUser =await _userManager.FindByEmailAsync(VerifyEmail);
            if (appUser==null)
            {
                return RedirectToAction("TokenIsNotValid");
            }
            await _userManager.ConfirmEmailAsync(appUser, token);
            await _userManager.UpdateSecurityStampAsync(appUser);
            return RedirectToAction("Login");
        }
        public IActionResult TokenIsNotValid()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}

