using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCount.Models;

namespace WebCount.Services
{
    public interface IProductService
    {
        Task<GetProductsResponse> GetProductsAsync();
        void Add(Product product);
    }
}
