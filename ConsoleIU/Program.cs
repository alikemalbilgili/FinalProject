﻿using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleIU
{
    public class Program
    {
        static void Main(string[] args)
        {
        //    Data Transformaiton Object
        //    IoC
        //    ProductTest();
        //    Console.ReadKey();

        //    CategoryTest();

        //}

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    var result = productManager.GetProductDetails();
        //    if (result.IsSuccess)
        //    {
        //        foreach (var product in productManager.GetProductDetails().Data)
        //        {
        //            Console.WriteLine(product.ProductName + " / " + product.CategoryName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        }
    }
}
