using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCount.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
