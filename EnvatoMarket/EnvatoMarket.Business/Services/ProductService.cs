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
                if (await IsExist(p => p.Name.ToLower() == entity.Name.ToLower()))
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
                if (!await IsExist(p => p.Id == id))
                {
                    return false;
                }
                Product product = await GetEntity(p => p.Id == id);
                if (product.IsDeleted)
                {
                    return false;
                }
                List<Product> products = await GetAll();
                if (products.Where(p => p.Id != id).All(p => p.IsDeleted))
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

        public async Task<bool> Update(Product entity)
        {
            try
            {
                
                List<Product> products = await GetAll();
                if (products.Where(p => p.Id != entity.Id).All(p => p.IsDeleted))
                {
                    return false;
                }
                Product existProduct = await GetEntity(p => p.Id == entity.Id, "ProductImages", "ProductTags.Tag");
                
                if (existProduct.ProductImages.Count!=entity.ProductImages.Count)
                {
                    foreach (var existProductImage in existProduct.ProductImages)
                    {
                        await _productImageRepository.Delete(existProductImage);
                    }
                    foreach (var productImage in entity.ProductImages)
                    {
                        await _productImageRepository.Create(productImage);
                    }
                }
                else
                {
                    for (int i = 0; i < existProduct.ProductImages.Count; i++)
                    {
                        if (existProduct.ProductImages[i].Id != entity.ProductImages[i].Id)
                        {
                            foreach (var existProductImage in existProduct.ProductImages)
                            {
                                await _productImageRepository.Delete(existProductImage);
                            }
                            foreach (var productImage in entity.ProductImages)
                            {
                                await _productImageRepository.Create(productImage);
                            }
                        }
                    }
                }
                if (entity.ProductImages.Count!=existProduct.ProductImages.Count)
                {
                    foreach (var existProductTag in existProduct.ProductTags)
                    {
                        await _productTagRepository.Delete(existProductTag);
                    }
                    foreach (var productTag in entity.ProductTags)
                    {
                        await _productTagRepository.Create(productTag);
                    }
                }
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                entity.Updated = DateTime.Now;
                await _productRepository.Update(entity);
                await _productRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

