using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC5Tutorial.Areas.Products.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int ReorderQty { get; set; }

        public int Qty { get; set; }

        public decimal ListPrice { get; set; }

        public ProductSize Size { get; set; }
    }
}
