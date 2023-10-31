using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class AuthorService:IAuthorService
	{
        private readonly IAuthorRepository _authorRepository;
        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<bool> Create(Author entity)
        {
            try
            {
                if (await IsExist(a => a.Name.ToLower() == entity.Name.ToLower()))
                {
                    return false;
                }
                await _authorRepository.Create(entity);
                await _authorRepository.Commit();
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
                Author author = await GetEntity(a => a.Id == id);
                if (author.IsDeleted)
                {
                    return false;
                }
                List<Author> authors = await GetAll();
                if (authors.Where(a => a.Id != id).All(a => a.IsDeleted))
                {
                    return false;
                }
                author.IsDeleted = true;
                author.Removed = DateTime.Now;
                await _authorRepository.Update(author);
                await _authorRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Author>> GetAll(Expression<Func<Author, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _authorRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Author> GetEntity(Expression<Func<Author, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _authorRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Author, bool>> predicate = null)
        {
            try
            {
                return await _authorRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(Author entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                List<Author> authors = await GetAll();
                if (authors.Where(a => a.Id != entity.Id).All(a => a.IsDeleted))
                {
                    if (entity.IsDeleted)
                    {
                        return false;
                    }

                }
                await _authorRepository.Update(entity);
                await _authorRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

