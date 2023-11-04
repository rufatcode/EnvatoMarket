using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class CheckService:ICheckService
	{
        private readonly ICheckRepository _checkRepository;
        private readonly ICheckProductService _checkProductService;
		public CheckService(ICheckRepository checkRepository,ICheckProductService checkProductService)
		{
            _checkRepository = checkRepository;
            _checkProductService = checkProductService;
		}

        public  async Task<bool> Create(Check entity)
        {
            try
            {
                if (entity == null)
                {
                    return false;
                }
                await _checkRepository.Create(entity);
                foreach (var checkProduct in entity.CheckProducts)
                {
                    await _checkProductService.Create(new CheckProduct
                    {
                        Id = Guid.NewGuid().ToString(),
                        CheckId=entity.Id,
                        ProductId=checkProduct.ProductId,
                        Price=checkProduct.Product.Price,
                        ProductCount=checkProduct.ProductCount
                    });
                }
                await _checkRepository.Commit();
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
                Check check = await GetEntity(c => c.Id == id);
                if (check.IsDeleted)
                {
                    return false;
                }
                List<Check> checks = await GetAll();
                if (checks.Where(c => c.Id != id).All(c => c.IsDeleted))
                {
                    return false;
                }
                check.IsDeleted = true;
                check.Removed = DateTime.Now;
                await _checkRepository.Update(check);
                await _checkRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Check>> GetAll(Expression<Func<Check, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _checkRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Check> GetEntity(Expression<Func<Check, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _checkRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Check, bool>> predicate = null)
        {
            try
            {
                return await _checkRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public Task<bool> Update(Check entity)
        {
            throw new NotImplementedException();
        }
    }
}

