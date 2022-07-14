
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductAddTest();
            ProductManager manager = new ProductManager(new EfProductDal());

            Product product1 = new Product();
            product1.ProductName = "Beyaz yazlık elbise";
            product1.UnitsInSock = 56;
            product1.UnitPrice = 575;
            product1.CategoryId = 2;
            product1.BrandId = 3;
            product1.ColorId = 2;
            manager.Add(product1); 

            foreach (var product in manager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " ---- "+ product.BrandName + " ---- " + product.CategoryName + " ---- " + 
                    product.ColorName );
            }


        }

        private static void ProductAddTest()
        {
            ProductManager manager = new ProductManager(new EfProductDal());
            Product product = new Product();
            product.ProductName = "Kazak";
            product.UnitsInSock = 152;
            product.UnitPrice = 85;
            product.CategoryId = 1;
            product.BrandId = 1;
            product.ColorId = 1;
            manager.Add(product);
        }
    }
}
