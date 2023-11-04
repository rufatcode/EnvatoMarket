using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class TagService:ITagService
	{
        private readonly ITagRepository _tagRepository;
        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }


        public async Task<bool> Create(Tag entity)
        {
            try
            {
                if (await IsExist(t => t.Name == entity.Name))
                {
                    return false;
                }
                await _tagRepository.Create(entity);
                await _tagRepository.Commit();
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
                if (!await IsExist(t => t.Id == id))
                {
                    return false;
                }
                Tag tag = await GetEntity(t => t.Id == id);
                if (tag.IsDeleted)
                {
                    return false;
                }
                List<Tag> tags = await GetAll();
                if (tags.Where(t => t.Id != id).All(t => t.IsDeleted))
                {
                    return false;
                }
                tag.IsDeleted = true;
                tag.Removed = DateTime.Now;
                await _tagRepository.Update(tag);
                await _tagRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Tag>> GetAll(Expression<Func<Tag, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _tagRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Tag> GetEntity(Expression<Func<Tag, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _tagRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Tag, bool>> predicate = null)
        {
            try
            {
                return await _tagRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(Tag entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                List<Tag> tags = await GetAll();
                if (tags.Where(t => t.Id != entity.Id).All(t => t.IsDeleted))
                {
                    if (entity.IsDeleted)
                    {
                        return false;
                    }

                }
                await _tagRepository.Update(entity);
                await _tagRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

