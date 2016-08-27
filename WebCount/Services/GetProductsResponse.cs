using WebCount.Models;
using System;
using System.Collections.Generic;

namespace WebCount.Services
{
    public class GetProductsResponse
    {
        public IEnumerable<Product> Products { get; set; }
        public bool Success { get; set; }
        public Exception OperationException { get; set; }
    }
}