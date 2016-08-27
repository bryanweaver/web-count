using System.Collections.Generic;

namespace WebCount.Models
{
    public class ProductType : IBaseModel
    {
        public ProductType()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}