using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject2Halak
{
    public partial class Form1 : Form
    {
        private HelperLogic hl = new HelperLogic();

        public Form1()
        {
            InitializeComponent();
            label1.Text = "Визначити інтерфейс Товар, похідні абстрактні  класи Молочний товар, М’ясний товар.\r\nТа похідні класи: Молоко, Кефір, Ковбаса, М’ясо. Ввести дані про 10 товарів і вивести їх у порядку спадання кодів. \r\nВидрукувати  список молочних товарів, ціна яких не перевищує задану. Вивести ті м’ясні товари, запас яких є більший за задане число";
            hl.AddInstances();
        }
      
        private void btn_SortQuantity_Click(object sender, EventArgs e)
        {
            hl.SortedMeatProducts(txt_ShowData);
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            hl.SortedMilkProducts(txt_ShowData);
        }

        private void CodeDescendingList_Click(object sender, EventArgs e)
        {
            hl.SortByID(txt_ShowData);
            hl.toXMLSortedByID();
        }
    }
}
