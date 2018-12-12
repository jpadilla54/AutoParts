using AutoParts.Aplication.Dtos;
using AutoParts.Domain.Commons;
using AutoParts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Aplication.Services
{
    public class ProductServices
    {
        private readonly IRepository<Product> _products;
        public ProductServices(IRepository<Product> products)
        {
            _products = products;
        }

        public void CreateProduct(ProductDto productDto)
        {
            _products.Add(new Product(productDto.Id, productDto.Name, productDto.Cost, productDto.Price));
            _products.Save();
        }

        public void AddProduct(int id, int quantity)
        {
            _products.Get(p => p.Id == id).AddToInventory(quantity);
            _products.Save();
        }

        public void RemoveFromInventory(int id, int quantity)
        {
            _products.Get(p => p.Id == id).RemoveFromInventory(quantity);
            _products.Save();

        }

        public IEnumerable<ProductDto> GetProducts()
        {
            var products = _products.GetAll();
            foreach (var product in products)
            {
                yield return new ProductDto() {
                    Id = product.Id,
                    Cost = product.Cost,
                    Price = product.Price,
                    Name = product.Name,
                    Quantity = product.Quantity };
            }
        }
    }

}