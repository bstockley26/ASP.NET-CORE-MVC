using System;
using BestBuyCRUDApp.Models;

namespace BestBuyCRUDApp.Data
{
	public interface IProductRepository
	{
        public IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
        void UpdateProduct(Product product);
        public Product AssignCategory();
        public IEnumerable<Category> GetCategories();
        public void InsertProduct(Product productToInsert);
        public void DeleteProduct(Product product);


    }
}

