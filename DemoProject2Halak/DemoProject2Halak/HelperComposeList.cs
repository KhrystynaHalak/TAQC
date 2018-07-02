using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DemoProject2Halak
{
    public class HelperComposeList
    {
        public List<Product> returnedList = new List<Product>();
        public HelperComposeList()
        {

        }

        public List<Product> MeatProductsReadXML(string pathXML)
        {
            //List<Product> returnedList = new List<Product>();
            pathXML = @"C:\Users\galak\Desktop\SortedMeatProducts.xml";

            XmlDocument doc = new XmlDocument();

            doc.Load(pathXML);
            try
            {

                foreach (XmlNode item in doc.GetElementsByTagName("Product"))
                {
                    returnedList.Add(new Product(item.Attributes.GetNamedItem("Name").InnerText,
                        int.Parse(item["Price"].InnerText),
                        int.Parse(item["Quantity"].InnerText),
                        int.Parse(item["ID"].InnerText)));
                };
                return returnedList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnedList;
        }
    }
}
