using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class BrandService:IBrandService
	{
        private readonly IBrandRepository _brandRepozitory;
        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepozitory  = brandRepository;
        }

        public async Task<bool> Create(Brand entity)
        {
            try
            {
                if (await IsExist(c => c.Name == entity.Name))
                {
                    return false;
                }
                await _brandRepozitory.Create(entity);
                await _brandRepozitory.Commit();
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
                Brand brand = await GetEntity(c => c.Id == id);
                if (brand.IsDeleted)
                {
                    return false;
                }
                List<Brand> categories = await GetAll();
                if (categories.Where(s => s.Id != id).All(s => s.IsDeleted))
                {
                    return false;
                }
                brand.IsDeleted = true;
                brand.Removed = DateTime.Now;
                await _brandRepozitory.Update(brand);
                await _brandRepozitory.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Brand>> GetAll(Expression<Func<Brand, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _brandRepozitory.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Brand> GetEntity(Expression<Func<Brand, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _brandRepozitory.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Brand, bool>> predicate = null)
        {
            try
            {
                return await _brandRepozitory.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(Brand entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                List<Brand> brands = await GetAll();
                if (brands.Where(s => s.Id != entity.Id).All(s => s.IsDeleted))
                {
                    if (entity.IsDeleted)
                    {
                        return false;
                    }

                }
                await _brandRepozitory.Update(entity);
                await _brandRepozitory.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

