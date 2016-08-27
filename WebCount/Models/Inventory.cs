using System;

namespace WebCount.Models
{
    public class Inventory : IBaseModel
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public Guid UniqueKey { get; set; }

        public bool IsAvailable { get; set; }

        public virtual Product Product { get; set; }
    }
}