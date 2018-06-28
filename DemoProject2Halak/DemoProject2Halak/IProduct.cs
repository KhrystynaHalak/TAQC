using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoProject2Halak
{
    interface IProduct
    {
        int Price { get; set; }

        string Name { get; set; }

        int Quantity { get; set;}

        int ID { get; set; }
    }

}

