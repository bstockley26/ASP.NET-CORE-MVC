using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestBuyCRUDApp.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BestBuyCRUDApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = _repository.GetAllProducts();
            return View(products);
        }

        public IActionResult ViewProduct (int id)
        {
            var product = _repository.GetProduct(id);
            return View(product);
        }
    }
}

