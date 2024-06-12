using System;
using BestBuyCRUDApp.Models;

namespace BestBuyCRUDApp.Data
{
	public interface IProductRepository
	{
        public IEnumerable<Product> GetAllProducts();
    }
}

