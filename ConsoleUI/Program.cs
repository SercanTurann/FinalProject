using Business.Concrete;
using DateAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }

            List<Product> products = new List<Product>()
            {
                new Product(){ProductId = 1 , CategoryId = 2,ProductName = "Acer Laptop" , UnitPrice = 10000 , UnitsInStock = 5 },
                new Product(){ProductId = 3 , CategoryId = 2,ProductName = "HP Laptop" , UnitPrice = 12000 , UnitsInStock = 10 },
                new Product(){ProductId = 3 , CategoryId = 2,ProductName = "Del Laptop" , UnitPrice = 15000 , UnitsInStock = 6 },
                new Product(){ProductId = 4 , CategoryId = 1,ProductName = "Apple Laptop" , UnitPrice = 30000 , UnitsInStock = 5 },
                new Product(){ProductId = 5 , CategoryId = 1,ProductName = "Monster Laptop" , UnitPrice = 20000 , UnitsInStock = 1 }

            };

        }

    }
}
