using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class ChatMessageService:IChatMessageService
	{
        private readonly IChatMessageRepository _chatMessageRepository;
		public ChatMessageService(IChatMessageRepository chatMessageRepository)
		{
            _chatMessageRepository = chatMessageRepository;
		}

        public async Task<bool> Create(ChatMessage entity)
        {
            try
            {
                if (entity.Message.Trim()=="")
                {
                    return false;
                }
                await _chatMessageRepository.Create(entity);
                await _chatMessageRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Delete(string id)
        {

            try
            {
                if (!await IsExist(c => c.Id == id))
                {
                    return false;
                }
                ChatMessage chatMessage = await GetEntity(c => c.Id == id);
                if (chatMessage.IsDeleted)
                {
                    return false;
                }
                chatMessage.IsDeleted = true;
                chatMessage.Removed = DateTime.Now;
                await _chatMessageRepository.Update(chatMessage);
                await _chatMessageRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<ChatMessage>> GetAll(Expression<Func<ChatMessage, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _chatMessageRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<ChatMessage> GetEntity(Expression<Func<ChatMessage, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _chatMessageRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<ChatMessage, bool>> predicate = null)
        {
            try
            {
                return await _chatMessageRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(ChatMessage entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                if (entity.Message.Trim()=="")
                {
                    return false;
                }
                await _chatMessageRepository.Update(entity);
                await _chatMessageRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

