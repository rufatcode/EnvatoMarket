using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class SettingService:ISettingService
	{
        private readonly ISettingRepository _settingRepository;
		public SettingService(ISettingRepository settingRepository)
		{
            _settingRepository = settingRepository;
		}

        public async Task<bool> Create(Setting entity)
        {
            try
            {
                if (await IsExist(s => s.Key == entity.Key))
                {
                    return false;
                }
                await _settingRepository.Create(entity);
                await _settingRepository.Commit();
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
                Setting setting = await GetEntity(s => s.Id == id);
                if (setting.IsDeleted)
                {
                    return false;
                }
                List<Setting> settings = await GetAll();
                if (settings.Where(s => s.Id != id).All(s => s.IsDeleted))
                {
                    return false;
                }
                setting.IsDeleted = true;
                setting.Removed = DateTime.Now;
                await _settingRepository.Update(setting);
                await _settingRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Setting>> GetAll(Expression<Func<Setting, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _settingRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Setting> GetEntity(Expression<Func<Setting, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _settingRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Dictionary<string, string>> GetSettingByKeyValue(Expression<Func<Setting, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _settingRepository.GetSettingByKeyValue(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Setting, bool>> predicate = null)
        {
            try
            {
                return await _settingRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(Setting entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                List<Setting> settings = await GetAll();
                if (settings.Where(s => s.Id != entity.Id).All(s => s.IsDeleted))
                {
                    if (entity.IsDeleted)
                    {
                        return false;
                    }

                }
                await _settingRepository.Update(entity);
                await _settingRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

