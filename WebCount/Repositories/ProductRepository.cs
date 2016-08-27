using WebCount.Models;
using System.Collections.Generic;
using Dapper;

namespace WebCount.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            using (var connection = GetConnection())
            {
                IEnumerable<Product> products = connection.Query<Product>(@"select [Id], [Name], [ProductTypeId] from Product");
                return products;
            }
        }

        public void Add(Product product)
        {
            using (var connection = GetConnection())
            {
                var query = @"insert into [Product] (Id, Name, ProductTypeId)
                            values (@id, @name, @typeId)";

                connection.Execute(query, new { id = product.Id, name = product.Name, typeId = product.ProductTypeId });
            }
        }
    }
}