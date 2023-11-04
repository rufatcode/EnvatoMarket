using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class CheckProductService:ICheckProductService
	{
        private readonly ICheckProductRepository _checkProductRepository;
		public CheckProductService(ICheckProductRepository checkProductRepository)
		{
            _checkProductRepository = checkProductRepository;
		}

        public async Task<bool> Create(CheckProduct entity)
        {
            try
            {
                if (entity==null)
                {
                    return false;
                }
                await _checkProductRepository.Create(entity);
                await _checkProductRepository.Commit();
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
                if (!await IsExist(cp => cp.Id == id))
                {
                    return false;
                }
                CheckProduct checkProduct = await GetEntity(cp => cp.Id == id);
                if (checkProduct.IsDeleted)
                {
                    return false;
                }
                List<CheckProduct> checkProducts = await GetAll();
                if (checkProducts.Where(cp => cp.Id != id).All(cp => cp.IsDeleted))
                {
                    return false;
                }
                checkProduct.IsDeleted = true;
                checkProduct.Removed = DateTime.Now;
                await _checkProductRepository.Update(checkProduct);
                await _checkProductRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<CheckProduct>> GetAll(Expression<Func<CheckProduct, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _checkProductRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<CheckProduct> GetEntity(Expression<Func<CheckProduct, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _checkProductRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<CheckProduct, bool>> predicate = null)
        {
            try
            {
                return await _checkProductRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(CheckProduct entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                List<CheckProduct> checkProducts = await GetAll();
                if (checkProducts.Where(cp => cp.Id != entity.Id).All(cp => cp.IsDeleted))
                {
                    if (entity.IsDeleted)
                    {
                        return false;
                    }

                }
                await _checkProductRepository.Update(entity);
                await _checkProductRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

