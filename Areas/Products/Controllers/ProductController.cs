using Microsoft.AspNetCore.Mvc;
using MVC5Tutorial.Areas.Products.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;

namespace MVC5Tutorial.Areas.Products.Controllers
{
    [Area("products")]
    [Route("/product")]
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        [Route("/ListAllProducts")]
        public IActionResult ListAllProducts()
        {
            IEnumerable<Product> products =  repository.Products;
            return View(products);
        }

        [Route("/GetProductDetails/{id}")]
        public IActionResult GetProductDetails(int id)
        {
            return View(repository[id]);
        }
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
