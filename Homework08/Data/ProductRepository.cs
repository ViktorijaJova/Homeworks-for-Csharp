using Hoemwork08e.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoemwork08e.Data
{
    public class ProductRepository : Data
    {
        public ProductRepository()
            : base()
        { }

        public List<Product> GetAllProducts()
        {
            return products;
        }


        public List<Product> GetProductByCategory(Category category, List<Product> products)
        {
            var CategoryProduct = new List<Product>();

            foreach (var product in products)
            {
                if (product.Category == category)
                {
                    CategoryProduct.Add(product);
                }

            }
            return CategoryProduct;
        }

        public List<Product> GetProductByPriceRange(int from, int to, List<Product> products)
        {
            var viePriceRange = new List<Product>();
            foreach (var product in products)
            {
                if (product.Price > from && product.Price < to)
                {

                    viePriceRange.Add(product);

                }

            }
            return viePriceRange;

        }

        public Product GetbyName(string name,List<Product>products)
        {

            foreach (var product in products)
            {
                if (product.Name.ToLower().Contains(name.ToLower()))
                {
                    return product;
                }
            }
            return null;
        }

        public List<long> GetProductbyId(List<Product> products)
        {
            var getbyid = new List<long>();

            foreach (var product in products)
            {
                getbyid.Add(product.Id);

            }
            return getbyid;
        }

        public long GetPrice(int id, List<Product> products)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    return product.Price;
                }
            }
            return 0;
        }

        public Product CheapestProduct(List<Product> products)
        {
            Product cheapestproduct = products[0];
            foreach (var product in products)
            {
                if (product.Price < cheapestproduct.Price)
                {
                    cheapestproduct = product;
                }
            }
            return cheapestproduct;
            ;
        }

        public Product ExpensiveProduct(List<Product> products)
        {
            Product expensiveproduct = products[0];
            foreach (var product in products)
            {
                if (product.Price > expensiveproduct.Price)
                {
                    expensiveproduct = product;
                }
            }
            return expensiveproduct;
        }

        public void AddProduct(Product product,List<Product>products)

        {
           products.Add(product);
        }

        public List<Product> RemoveProduct(int id,List<Product>products)
        {
            var deletedproducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.Id != id)
                {
                    deletedproducts.Add(product);
                }
            }
            return deletedproducts;
        }


    }
}