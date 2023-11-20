using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Business.Services;
using EnvatoMarket.Business.ViewModels.ChatVM;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnvatoMarket.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        // GET: /<controller>/
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IChatMessageService _chatMessageService;
        public ChatController(UserManager<AppUser> userManager,IMapper mapper,IChatMessageService chatMessageService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _chatMessageService = chatMessageService;
        }
        public async Task<IActionResult> Index()
        {
            AppUser appUser = await _userManager.Users.Include(usr => usr.SentMessages).Include(usr => usr.ReceivedMessages).Where(u=>u.UserName==User.Identity.Name).FirstOrDefaultAsync();
            ChatIndexVM chatIndexVM = new();
            
            chatIndexVM.AppUser = await _userManager.Users.Where(u=>u.Id!=appUser.Id).ToListAsync();
           
            foreach (var admin in await _userManager.GetUsersInRoleAsync("SupperAdmin"))
            {
                chatIndexVM.SupperAdmin=admin;
            }
            chatIndexVM.MyProfile = appUser;
            return View(chatIndexVM);
        }
       
        [HttpPost]
        public async Task<IActionResult>SendMessage([FromBody]SendMessageVM sendMessageVM)
        {
            if (sendMessageVM.Message.Trim()=="")
            {
                return BadRequest();
            }
            else if (await _userManager.FindByIdAsync(sendMessageVM.ToUserId)==null)
            {
                return BadRequest();
            }
            else if (await _userManager.FindByIdAsync(sendMessageVM.FromUserId)==null)
            {
                return BadRequest();
            }
            ChatMessage chatMessage =_mapper.Map<ChatMessage>(sendMessageVM);
            chatMessage.Id = Guid.NewGuid().ToString();
            bool isSuccess=await _chatMessageService.Create(chatMessage);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> RecieveMessage([FromBody]SendMessageVM sendMessageVM)
        {
            if (sendMessageVM.Message.Trim() == "")
            {
                return BadRequest();
            }
            else if (await _userManager.FindByIdAsync(sendMessageVM.ToUserId) == null)
            {
                return BadRequest();
            }
            else if (await _userManager.FindByIdAsync(sendMessageVM.FromUserId) == null)
            {
                return BadRequest();
            }
            ChatMessage chatMessage = _mapper.Map<ChatMessage>(sendMessageVM);
            chatMessage.Id = Guid.NewGuid().ToString();
            bool isSuccess = await _chatMessageService.Create(chatMessage);
            if (!isSuccess)
            {
                return BadRequest();
            }
            MessagePartialVM messagePartialVM = new();
            messagePartialVM.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);
            messagePartialVM.UserId = sendMessageVM.FromUserId;
            messagePartialVM.Message = _mapper.Map<RecieveMessageVM>(chatMessage);
            return PartialView("_ReciveMessage", messagePartialVM);
        }
        public async Task<IActionResult> UserMessage(string userId)
        {
            ChatPartialVM chatPartialVM = new();
            AppUser appUser = await _userManager.Users.Include(usr => usr.SentMessages).ThenInclude(m=>m.ToUser).Include(usr => usr.ReceivedMessages).ThenInclude(m=>m.FromUser).Where(u => u.UserName == User.Identity.Name).FirstOrDefaultAsync();
            List<RecieveMessageVM> Messages = new();
            foreach (var message in appUser.ReceivedMessages.Where(m=>!m.IsDeleted&&m.FromUserId==userId).ToList())
            {
                Messages.Add(_mapper.Map<RecieveMessageVM>(message));
            }
            foreach (var message in appUser.SentMessages.Where(m => !m.IsDeleted&m.ToUserId==userId).ToList())
            {
                Messages.Add(_mapper.Map<RecieveMessageVM>(message));
            }
            Messages = Messages.OrderBy(m => m.Created).ToList();
            chatPartialVM.Messages = Messages;
            chatPartialVM.AppUser = await _userManager.FindByIdAsync(userId);
            chatPartialVM.TotalMessage = Messages.Count;
            chatPartialVM.FromUser = appUser;
            chatPartialVM.ToUser = chatPartialVM.AppUser;
            return PartialView("_ChatPartial", chatPartialVM);
        }
    }
}

