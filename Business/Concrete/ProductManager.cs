using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (product.ProductName == null || product.ProductName.Length < 2)
            {
                Console.WriteLine("Ürün adı 2 haneden büyük olmalıdır!");
            }
            else
            {
                _productDal.Add(product);
                Console.WriteLine("Ürün eklendi " + product.ProductName);
            }
        }
            

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetById(int id)
        {
            return _productDal.GetAll(p => p.ProductId == id);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
