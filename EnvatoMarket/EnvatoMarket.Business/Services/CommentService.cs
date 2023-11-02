using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class CommentService:ICommentService
	{
        private readonly ICommentRepository _commentRepository; 
		public CommentService(ICommentRepository commentRepository)
		{
            _commentRepository = commentRepository;
		}

        public async Task<bool> Create(Comment entity)
        {
            try
            {
                if (entity==null||entity.UserId==null||entity.ProductId==null)
                {
                    return false;
                }
                await _commentRepository.Create(entity);
                await _commentRepository.Commit();
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
                Comment comment = await GetEntity(c => c.Id == id);
                if (comment.IsDeleted)
                {
                    return false;
                }
                
                comment.IsDeleted = true;
                comment.Removed = DateTime.Now;
                await _commentRepository.Update(comment);
                await _commentRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Comment>> GetAll(Expression<Func<Comment, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _commentRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Comment> GetEntity(Expression<Func<Comment, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _commentRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Comment, bool>> predicate = null)
        {
            try
            {
                return await _commentRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(Comment entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                
                await _commentRepository.Update(entity);
                await _commentRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

