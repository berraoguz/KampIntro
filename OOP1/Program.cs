﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = 5;
            product2.ProductName = "Kalem";
            product2.UnitPrice = 35;
            product2.UnitInStock = 5;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            





        }
    }
}
