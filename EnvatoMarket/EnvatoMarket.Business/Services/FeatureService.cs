using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class FeatureService:IFeatureService
	{
        private readonly IFeatureRepository _featureRepository;
		public FeatureService(IFeatureRepository featureRepository)
		{
            _featureRepository = featureRepository;
		}

        public async Task<bool> Create(Feature entity)
        {
            try
            {
                if (await IsExist(f => f.Title.ToLower() == entity.Title.ToLower()))
                {
                    return false;
                }
                await _featureRepository.Create(entity);
                await _featureRepository.Commit();
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
                if (!await IsExist(f => f.Id == id))
                {
                    return false;
                }
                Feature feature = await GetEntity(f => f.Id == id);
                if (feature.IsDeleted)
                {
                    return false;
                }
                List<Feature> features = await GetAll();
                if (features.Where(f => f.Id != id).All(f => f.IsDeleted))
                {
                    return false;
                }
                feature.IsDeleted = true;
                feature.Removed = DateTime.Now;
                await _featureRepository.Update(feature);
                await _featureRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Feature>> GetAll(Expression<Func<Feature, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _featureRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Feature> GetEntity(Expression<Func<Feature, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _featureRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Feature, bool>> predicate = null)
        {
            try
            {
                return await _featureRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(Feature entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                List<Feature> features = await GetAll();
                if (features.Where(f=> f.Id != entity.Id).All(f => f.IsDeleted))
                {
                    if (entity.IsDeleted)
                    {
                        return false;
                    }

                }
                await _featureRepository.Update(entity);
                await _featureRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

