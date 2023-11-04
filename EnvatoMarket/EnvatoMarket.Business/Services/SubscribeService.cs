using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class SubscribeService: ISubscribeService
    {
        private readonly ISubscribeRepository _subscribeRepository;
		public SubscribeService(ISubscribeRepository subscribeRepository)
		{
            _subscribeRepository = subscribeRepository;
		}

        public async Task<bool> Create(Subscribe entity)
        {
            try
            {
                if (await IsExist(s => s.Email == entity.Email))
                {
                    return false;
                }
                await _subscribeRepository.Create(entity);
                await _subscribeRepository.Commit();
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
                if (!await IsExist(s => s.Id == id))
                {
                    return false;
                }
                Subscribe subscribe = await GetEntity(s => s.Id == id);
                if (subscribe.IsDeleted)
                {
                    return false;
                }
                List<Subscribe> subscribes = await GetAll();
                if (subscribes.Where(s => s.Id != id).All(s => s.IsDeleted))
                {
                    return false;
                }
                subscribe.IsDeleted = true;
                subscribe.Removed = DateTime.Now;
                await _subscribeRepository.Update(subscribe);
                await _subscribeRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Subscribe>> GetAll(Expression<Func<Subscribe, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _subscribeRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Subscribe> GetEntity(Expression<Func<Subscribe, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _subscribeRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Subscribe, bool>> predicate = null)
        {
            try
            {
                return await _subscribeRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(Subscribe entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                List<Subscribe> subscribes = await GetAll();
                if (subscribes.Where(s => s.Id != entity.Id).All(s => s.IsDeleted))
                {
                    if (entity.IsDeleted)
                    {
                        return false;
                    }

                }
                await _subscribeRepository.Update(entity);
                await _subscribeRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

