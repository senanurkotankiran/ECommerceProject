
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetById(int id);
        List<ProductDetailDto> GetProductDetails();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
