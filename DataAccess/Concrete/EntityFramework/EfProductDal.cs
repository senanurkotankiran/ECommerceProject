using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ECommerceDbContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (ECommerceDbContext context = new ECommerceDbContext())
            {
                var result = from p in context.Products
                             join b in context.Brands
                             on p.BrandId equals b.BrandId
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             join co in context.Colors
                             on p.ColorId equals co.ColorId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 BrandName = b.BrandName,
                                 CategoryName = c.CategoryName,
                                 ColorName = co.ColorName,
                             };
                return result.ToList();
            }
        }
    }
}
