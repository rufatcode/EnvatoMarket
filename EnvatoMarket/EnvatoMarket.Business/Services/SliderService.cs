using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;

namespace EnvatoMarket.Business.Services
{
	public class SliderService:ISliderService
	{
        private readonly ISliderRepository _sliderRepozitory;
		public SliderService(ISliderRepository sliderRepository)
		{
            _sliderRepozitory = sliderRepository;
		}

        public async Task<bool> Create(Slider entity)
        {
            try
            {
                if (entity==null||entity.Description==null||entity.Title==null||entity.ImageUrl==null)
                {
                    return false;
                }
               await _sliderRepozitory.Create(entity);
                await _sliderRepozitory.Commit();
               return true;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<bool> Delete(string id)
        {
            try
            {
                if (!await IsExist(s=>s.Id==id))
                {
                    return false;
                }
                Slider slider = await GetEntity(s=>s.Id==id);
                if (slider.IsDeleted==true)
                {
                    return false;
                }
                List<Slider> sliders = await GetAll();
                if (sliders.Where(s=>s.Id!=id).All(s=>s.IsDeleted))
                {
                    return false;
                }
                
                slider.IsDeleted = true;
                slider.Removed = DateTime.Now;
                await _sliderRepozitory.Update(slider);
                await _sliderRepozitory.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<List<Slider>> GetAll(Expression<Func<Slider, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _sliderRepozitory.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<Slider> GetEntity(Expression<Func<Slider, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _sliderRepozitory.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }


        public async Task<bool> IsExist(Expression<Func<Slider, bool>> predicate = null)
        {
            try
            {
                return await _sliderRepozitory.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<bool> Update(Slider entity)
        {


            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                await _sliderRepozitory.Update(entity);
                await _sliderRepozitory.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}

