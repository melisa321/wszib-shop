using System;
using System.Collections.Generic;
using System.Text;
using Shop.Core.DTO;
using Shop.Core.Repositories;
using Shop.Core.Domain;

namespace Shop.Core.Services
{
    public class ProductService : IProductService
    {

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        

        public IEnumerable<ProductDto> GetAll()
        {
            throw new NotImplementedException()
                => _productRepository
                .GetAll()
                .Select(prop => new ProductDto
             {
                             Id = prop.Id,
                             Name = prop.Name,
                             Category = prop.Category,
                             Price = prop.Price

             });
        }

        public void Add(string name, string category, decimal price)
        {
            var product = new Product(name, category, price);
            _productRepository.Add(product);
        }
    }
}
