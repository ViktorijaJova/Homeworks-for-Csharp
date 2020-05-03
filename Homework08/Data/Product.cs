using Hoemwork08e.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoemwork08e.Data
{
     public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }

        public Category Category { get; set; }

        private static int _idGenerator = 0;


        public Product(string name,long price,Category category)
        {
            Id = _idGenerator;
            Name = name;
            Price = price;
            Category = category;
            _idGenerator++;
        }
        public string Info()
        {

            return $"{Id}, Name {Name} Price {Price} Category {Category}";           

        }

    }

}
