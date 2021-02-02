using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC5Tutorial.Areas.Products.Models
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => ProductList.Values;
        public Product this[int id]
        {
            get
            {
                return ProductList.ContainsKey(id) ? ProductList[id] : null;
            }
            set
            {
                ProductList[id] = value;
            }
        }

        private Dictionary<int, Product> ProductList = new Dictionary<int, Product>
        {
            [1] = new Product
            {
                ProductID = 1,
                Name = "Classic Vest, S",
                Code = "VE-C304-S",
                ReorderQty = 30,
                Qty = 40,
                ListPrice = 80,
                Size = ProductSize.Small
            },
            [2] = new Product
            {
                ProductID = 2,
                Name = "Classic Vest, L",
                Code = "VE-C304-L",
                ReorderQty = 10,
                Qty = 50,
                ListPrice = 65,
                Size = ProductSize.Large
            },
            [3] = new Product
            {
                ProductID = 3,
                Name = "Mountain Bike Socks, M",
                Code = "SO-B909-M",
                ReorderQty = 25,
                Qty = 20,
                ListPrice = 40,
                Size = ProductSize.Medium
            },
            [4] = new Product
            {
                ProductID = 4,
                Name = "Long-Sleeve Logo Jersey, XL",
                Code = "LJ-0192-X",
                ReorderQty = 15,
                Qty = 55,
                ListPrice = 62,
                Size = ProductSize.XtraLarge
            },
            [5] = new Product
            {
                ProductID = 5,
                Name = "Women's Mountain Shorts, S",
                Code = "SH-W890-S",
                ReorderQty = 10,
                Qty = 18,
                ListPrice = 62,
                Size = ProductSize.Small
            }
        };
    }
}
