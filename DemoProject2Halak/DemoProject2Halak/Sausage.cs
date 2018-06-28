using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject2Halak
{
    [Serializable]
    public class Sausage : MeatProducts, IProduct
    {
        public new int Price { get; set; }
        public new string Name { get; set; }
        public new int Quantity { get; set; }
        public new int ID { get; set; }

        public Sausage()
        {

        }

        public Sausage(int price, string name, int quantity, int id)
        {
            this.Price = price;
            this.Name = name;
            this.Quantity = quantity;
            this.ID = id;
        }
        public override void HigherQuantity(int setQuantity, TextBox textbox)
        {
            if (Quantity > setQuantity)
            {
                textbox.Text += "\r\n" + "Name of a Product is: " + Name + "  " + "the price is: " + Price + "  " + "the quantity is" + Quantity + "  " + "this id is: " + ID + "\n\t";
            }
        }
    }
}
