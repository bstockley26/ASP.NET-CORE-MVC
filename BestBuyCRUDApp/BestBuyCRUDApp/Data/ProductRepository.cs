using System;
using System.Data;
using BestBuyCRUDApp.Models;
using Dapper;

namespace BestBuyCRUDApp.Data
{
	public class ProductRepository : IProductRepository
	{
        private readonly IDbConnection _connection;

        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM products;");
        }
    }
}

