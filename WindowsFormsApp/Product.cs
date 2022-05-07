
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;


namespace WindowsFormsApp
{[Serializable]
    public class Product
    {
        public int ProdID { get; set; }
        public String ProdName { get; set; }
        public double ProdPrice { get; set; }
        public string ProdCategory { get; set; }
    }
    class TestProd
    {
       

        static void Main(string[] args)
        {
            FileStream fs;
            //Using Binary Serilization store Data
            
            Product prod = new Product()
            { ProdID = 1, ProdName = "Adidas", ProdCategory = "Jackets", ProdPrice = 3089.2 };

            try
            {
                 fs = new FileStream(@"D:\New Test\prod", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, prod);
                MessageBox.Show("Binary Serilization");
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            //Using XML Serilization store Data
            try
            {
                fs = new FileStream(@"D:\New Test\prodXML", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                xml.Serialize(fs, prod);
                MessageBox.Show("XML Serilization");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            //Using SOAP Serilization store Data
            try
            {
                fs = new FileStream(@"D:\New Test\prodSOAP", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, prod);
                MessageBox.Show("SOAP Serilization");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            // Using JSON Serilization store Data
            try
            {
                fs = new FileStream(@"D:\New Test\prodJason", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, prod);
                MessageBox.Show("Json Serilization");

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
        }
    }
    
}
