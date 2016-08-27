using System.Collections.Generic;

namespace WebCount.Models
{
    public class Product : IBaseModel
    {
        public Product()
        {
            Inventories = new List<Inventory>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}