﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryId + "--" + category.CategoryName);
            }
        }

        private void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName + "----" + product.UnitPrice + " **** Category: " + product.CategoryId);
            }
            Console.WriteLine("/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/-*/");
            foreach (var productSec in productManager.GettByUnitPrice(200, 2000))
            {
                Console.WriteLine(productSec.ProductName + "-------" + productSec.UnitPrice);
            }
        }
    }
}
