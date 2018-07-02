using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject2Halak
{
    public class Product: IProduct
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int ID { get; set; }

        public Product()
        {

        }

        public Product(string name, int price,  int quantity, int id)
        {
            Price = price;
            Name = name;
            Quantity = quantity;
            ID = id;
        }
    }
}
