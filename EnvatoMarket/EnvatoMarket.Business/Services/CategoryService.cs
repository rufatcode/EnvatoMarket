using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Services
{
	public class CategoryService:ICategoryService
	{
        private readonly ICategoryRepository _categoryRepozitory;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepozitory = categoryRepository;
        }

        public async Task<bool> Create(Category entity)
        {
            try
            {
                if (await IsExist(c=>c.CategoryName.ToLower()==entity.CategoryName.ToLower()))
                {
                    return false;
                }
                await _categoryRepozitory.Create(entity);
                await _categoryRepozitory.Commit();
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
                if (!await IsExist(c=>c.Id==id))
                {
                    return false;
                }
                Category category = await GetEntity(c => c.Id == id);
                if (category.IsDeleted)
                {
                    return false;
                }
                List<Category> categories = await GetAll();
                if (categories.Where(s => s.Id != id).All(s => s.IsDeleted))
                {
                    return false;
                }
                category.IsDeleted = true;
                category.Removed = DateTime.Now;
                await _categoryRepozitory.Update(category);
                await _categoryRepozitory.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Category>> GetAll(Expression<Func<Category, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _categoryRepozitory.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Category> GetEntity(Expression<Func<Category, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _categoryRepozitory.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Category, bool>> predicate = null)
        {
            try
            {
                return await _categoryRepozitory.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(Category entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                List<Category> categories = await GetAll();
                if (categories.Where(s => s.Id != entity.Id).All(s => s.IsDeleted))
                {
                    if (entity.IsDeleted)
                    {
                        return false;
                    }
                   
                }
                await _categoryRepozitory.Update(entity);
                await _categoryRepozitory.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
            
        }
    }
}

