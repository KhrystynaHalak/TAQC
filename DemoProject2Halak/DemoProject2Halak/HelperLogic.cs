﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DemoProject2Halak
{
    class HelperLogic
    {
        XmlDocument a;
        XDocument b = XDocument.Load(@"C:/Users/galak/Desktop/ProductsSortedByID.xml");
        public static List<IProduct> prod = new List<IProduct>();

        public void AddInstances()
        {
            prod.Add(new Milk(135, "Buttermilk", 5, 9));
            prod.Add(new Sausage(135, "Cooked sausages", 5, 18));
            prod.Add(new Meat(12, "Red meat", 5, 5));
            prod.Add(new Kefir(12, "Shubat", 5, 89));
            prod.Add(new Milk(135, "Chalap", 5, 23));
            prod.Add(new Sausage(135, "Cured and aged sausage", 5, 6));
            prod.Add(new Meat(12, "WhiteMeat", 5, 11));
            prod.Add(new Kefir(12, "Matzoon", 5, 63));
            prod.Add(new Kefir(12, "Mursik", 5, 13));
            prod.Add(new Kefir(12, "Leben", 5, 10));

            //var studentLst = b.Descendants("Products").Select(d =>
            //new
            //{
            //    Price = d.Element("Price").Value,
            //    Name = d.Element("Product Name").Value,
            //    Quantity = d.Element("Quantity").Value,
            //    id = d.Element("Id").Value,
            //}).ToList();

        }
        public void SortedMilkProducts(TextBox textBox)
        {
            textBox.Text += "\r\nThe list of milk products with price less than set\r\n";

            foreach (var item in prod)
            {
                if (item.GetType() == typeof(Milk) || item.GetType() == typeof(Kefir))
                {
                    MilkProducts l = (MilkProducts)item;
                    l.PriceNotHigher(300, textBox);

                }
            }
        }
        public void SortedMeatProducts(TextBox textBox)
        {
            textBox.Text += "\r\nThe list of Meat Products with quantity highter than set\r\n";

            foreach (var item in prod)
            {
                if (item.GetType() == typeof(Sausage) || item.GetType() == typeof(Meat))
                {
                    MeatProducts l = (MeatProducts)item;
                    l.HigherQuantity(1, textBox);
                }
            }
        }
        public void ToXMLSortedMilkProducts()
        {
            List<IProduct> lm = new List<IProduct>();
            foreach (var item in prod)
            {
                if (item.GetType() == typeof(Milk) || item.GetType() == typeof(Kefir))
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = "  ";

                    MilkProducts l = (MilkProducts)item;
                    l.PriceNotHigher(300, textBox);

                    lm.Add(l);
                }
            }
            try
            {
                var xEle = new XElement("Products",
                    from ll in lm
                    select new XElement("Product",
                                   new XElement("Name", ll.Name),
                                   new XElement("Price", ll.Price),
                                   new XElement("Quantity", ll.Quantity),
                                   new XElement("ID", ll.ID)
                               ));

                xEle.Save("SortedMilkProducts.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ToXMLSortedMeatProducts()
        {
            List<IProduct> mp = new List<IProduct>();
            foreach (var item in prod)
            {
                if (item.GetType() == typeof(Meat) || item.GetType() == typeof(Sausage))
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = "  ";

                    MeatProducts mm = (MeatProducts)item;
                    mm.HigherQuantity(1, textBox);

                    mp.Add(mm);
                }
            }
            try
            {
                var xEle = new XElement("Products",
                    from ll in mp
                    select new XElement("Product",
                                   new XElement("Name", ll.Name),
                                   new XElement("Price", ll.Price),
                                   new XElement("Quantity", ll.Quantity),
                                   new XElement("ID", ll.ID)
                               ));

                xEle.Save("SortedMeatProducts.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SortByID(TextBox textBox)
        {
            textBox.Text += "\r\nList of product items due to ID\r\n";
            List<IProduct> sortedProducts = prod.OrderBy(o => o.ID).ToList();
            for (int i = 0; i < sortedProducts.Count; i++)
            {
                textBox.Text += "\r\n" + "Name of a Product is: " + sortedProducts[i].Name + "  " + "the price is: " + sortedProducts[i].Price + "  " + "the quantity is " + sortedProducts[i].Quantity + "  " + "this id is: " + sortedProducts[i].ID + "\n\t\n";
            }
        }

        public void toXMLSortedByID()
        {
            List<IProduct> sortedProducts = prod.OrderBy(o => o.ID).ToList();
            try
            {
                var xEle = new XElement("Products",
                            from sp in sortedProducts
                            select new XElement("Product",
                                         new XAttribute("Name", sp.Name),
                                           new XElement("Price", sp.Price),
                                           new XElement("Quantity", sp.Quantity),
                                           new XElement("ID", sp.ID)
                                       ));

                xEle.Save(@"C:\Users\galak\Desktop\ProductsSortedByID.xml");
                Console.WriteLine("Converted to XML");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
