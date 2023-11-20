using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class AdressService:IAdressSrevice
	{
        private readonly IAdressRepository _adressRepository;
		public AdressService(IAdressRepository adressRepository)
		{
            _adressRepository = adressRepository;
		}

        public async Task<bool> Create(Adress entity)
        {
            try
            {
                
                await _adressRepository.Create(entity);
                await _adressRepository.Commit();
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
                Adress adress = await GetEntity(a => a.Id == id);
                if (adress.IsDeleted)
                {
                    return false;
                }
                adress.IsDeleted = true;
                adress.Removed = DateTime.Now;
                await _adressRepository.Update(adress);
                await _adressRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Adress>> GetAll(Expression<Func<Adress, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _adressRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Adress> GetEntity(Expression<Func<Adress, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _adressRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Adress, bool>> predicate = null)
        {
            try
            {
                return await _adressRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(Adress entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                await _adressRepository.Update(entity);
                await _adressRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

