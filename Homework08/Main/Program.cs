using Hoemwork08e.Data;
using Hoemwork08e.Entites;
using System;
using System.Collections.Generic;

namespace Hoemwork08e
{
    class Program
    {
        static void Main(string[] args)

        {

            var productrepo = new ProductRepository();


            Console.WriteLine("Product by Name:" + productrepo.GetbyName("Gaming", productrepo.GetAllProducts()).Info());
            Console.WriteLine("Cheapest Product:" + productrepo.CheapestProduct(productrepo.GetAllProducts()).Info());
            Console.WriteLine("The most expensive product:" + productrepo.ExpensiveProduct(productrepo.GetAllProducts()).Info());

            var viePriceRange = productrepo.GetProductByPriceRange(50,1000,productrepo.GetAllProducts());
            foreach (var product in viePriceRange)
            {
                Console.WriteLine("By price range: " + product.Info());
            }
            var CategoryProduct = productrepo.GetProductByCategory(Category.PC, productrepo.GetAllProducts());
            foreach (var p in CategoryProduct)
            {
                Console.WriteLine(" By Category: " + p.Info());
            }


              productrepo.AddProduct(new Product("Canon", 500, Category.ItEquipment), productrepo.GetAllProducts());
              var deletedproducts = productrepo.RemoveProduct(12, productrepo.GetAllProducts());
              foreach (var product in deletedproducts)
            {
                Console.WriteLine("Removed product: " + product.Info());
                Console.ReadLine();

            }

           
         
            Console.ReadLine();
        }
    }
}
