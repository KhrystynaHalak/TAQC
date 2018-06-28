﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject2Halak
{
    [Serializable]
    public abstract class MeatProducts : IProduct
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int ID { get; set; }

        public abstract void HigherQuantity(int setQuantity, TextBox textbox);   
    }
}
