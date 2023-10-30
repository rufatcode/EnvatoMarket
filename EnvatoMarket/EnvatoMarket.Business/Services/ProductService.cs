using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class ProductService:IProductService
	{
        private readonly IProductRepository _productRepository;
        private readonly IProductTagRepository _productTagRepository;
        private readonly IProductImageRepository _productImageRepository;
		public ProductService(IProductRepository productRepository,IProductImageRepository productImageRepository,IProductTagRepository productTagRepository)
		{
            _productRepository = productRepository;
            _productImageRepository = productImageRepository;
            _productTagRepository = productTagRepository;
		}

        public async Task<bool> Create(Product entity)
        {
            try
            {
                if (await IsExist(c => c.Name.ToLower() == entity.Name.ToLower()))
                {
                    return false;
                }
                await _productRepository.Create(entity);
                foreach (var productImage in entity.ProductImages)
                {
                    await _productImageRepository.Create(productImage);
                }
                foreach (var productTag in entity.ProductTags)
                {
                    await _productTagRepository.Create(productTag);
                }
                await _productRepository.Commit();
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
                Product product = await GetEntity(c => c.Id == id);
                if (product.IsDeleted)
                {
                    return false;
                }
                List<Product> products = await GetAll();
                if (products.Where(s => s.Id != id).All(s => s.IsDeleted))
                {
                    return false;
                }
                product.IsDeleted = true;
                product.Removed = DateTime.Now;
                await _productRepository.Update(product);
                await _productRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Product>> GetAll(Expression<Func<Product, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _productRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Product> GetEntity(Expression<Func<Product, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _productRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Product, bool>> predicate = null)
        {
            try
            {
                return await _productRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public Task<bool> Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}

