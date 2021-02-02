using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC5Tutorial.Areas.Products.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        Product this[int ProductType] { get; set; }
    }
}
