using WebCount.Models;
using WebCount.Repositories;
using WebCount.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebCount.Controllers
{
    public class ProductController : ApiController
    {
        readonly IProductService _productService;

        public ProductController() {
            if (_productService == null)
            {
                _productService = new ProductService(new ProductRepository());
            }
        }

        public ProductController(IProductService productService)
        {
            if (_productService == null)
            {
                _productService = new ProductService(new ProductRepository());
            }
            _productService = productService;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            GetProductsResponse response = await _productService.GetProductsAsync();
            if (response.Success)
            {
                return Ok<IEnumerable<Product>>(response.Products);
            }

            return InternalServerError(response.OperationException);
        }
    }
}
