using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    //Ado.Net kodları olarak varsayalım
    public class ProductDal : IProductDal
    {
        List<Product> _products;
        public ProductDal()
        {
            _products = new List<Product> 
            {
                new Product {ProductId=1, ProductName="Acer PC", QuantityPerUnit="32GB Ram", UnitPrice=10000, UnitsInStock=2},
                new Product {ProductId=3, ProductName="Asus PC", QuantityPerUnit="32GB Ram", UnitPrice=10000, UnitsInStock=1},
                new Product {ProductId=4, ProductName="HP PC", QuantityPerUnit="32GB Ram", UnitPrice=10000, UnitsInStock=0},
                new Product {ProductId=2, ProductName="Mac PC", QuantityPerUnit="32GB Ram", UnitPrice=10000, UnitsInStock=3},
                new Product {ProductId=5, ProductName="Dell PC", QuantityPerUnit="32GB Ram", UnitPrice=10000, UnitsInStock=10}
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado.Net ile eklendi");
        }

        public Task AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Task<List<Product>> GetAllASync()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
