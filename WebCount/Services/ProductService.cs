using WebCount.Models;
using WebCount.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebCount.Services
{
    public class ProductService : IProductService
    {
        readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            if (productRepository == null)
            {
                _productRepository = new ProductRepository();
            }
            _productRepository = productRepository;
        }
        public async Task<GetProductsResponse> GetProductsAsync()
        {
            return await Task<GetProductsResponse>.Run(() => GetProducts());
        }

        private GetProductsResponse GetProducts()
        {
            GetProductsResponse response = new GetProductsResponse();
            try
            {
                IEnumerable<Product> products = _productRepository.GetAll();
                response.Products = products;
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.OperationException = ex;
            }
            return response;
        }
    }
}