using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class BlogService:IBlogService
	{
        private readonly IBlogRepository _blogRepository;
		public BlogService(IBlogRepository blogRepository)
		{
            _blogRepository = blogRepository;
		}

        public async Task<bool> Create(Blog entity)
        {
            try
            {
                await _blogRepository.Create(entity);
                await _blogRepository.Commit();
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
                if (!await IsExist(b => b.Id == id))
                {
                    return false;
                }
                Blog blog = await GetEntity(b => b.Id == id);
                if (blog.IsDeleted)
                {
                    return false;
                }
                List<Blog> blogs = await GetAll();
                if (blogs.Where(b => b.Id != id).All(b => b.IsDeleted))
                {
                    return false;
                }
                blog.IsDeleted = true;
                blog.Removed = DateTime.Now;
                await _blogRepository.Update(blog);
                await _blogRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Blog>> GetAll(Expression<Func<Blog, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _blogRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Blog> GetEntity(Expression<Func<Blog, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _blogRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Blog, bool>> predicate = null)
        {
            try
            {
                return await _blogRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(Blog entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                List<Blog> blogs = await GetAll();
                if (blogs.Where(b => b.Id != entity.Id).All(b => b.IsDeleted))
                {
                    if (entity.IsDeleted)
                    {
                        return false;
                    }

                }
                await _blogRepository.Update(entity);
                await _blogRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

