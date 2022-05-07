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
{

   
    public partial class Product_Information : Form
    {
        FileStream fs;
        public Product_Information()
        {
            InitializeComponent();
        }

        private void Button1_BinarySerialization_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.ProdID = Convert.ToInt32(textBox1_Id.Text);
                prod.ProdName = textBox2_ProdName.Text;
                prod.ProdPrice = Convert.ToDouble(textBox3_ProdPrice.Text);
                prod.ProdCategory = textBox4_CategoryName.Text;
                fs = new FileStream(@"D:\New Test\prodbinary1", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, prod);
                MessageBox.Show("Done");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {                
                fs.Close();
            }
        }

        private void button1_BinarySerialization_Read_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\New Test\prodbinary1", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                prod = (Product)binary.Deserialize(fs);
                textBox1_Id.Text = prod.ProdID.ToString();
                textBox2_ProdName.Text = prod.ProdName;
                textBox3_ProdPrice.Text = prod.ProdPrice.ToString();
                textBox4_CategoryName.Text = prod.ProdCategory;                
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void button2_XMLSerialization_Write_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.ProdID = Convert.ToInt32(textBox1_Id.Text);
                prod.ProdName = textBox2_ProdName.Text;
                prod.ProdPrice = Convert.ToDouble(textBox3_ProdPrice.Text);
                prod.ProdCategory = textBox4_CategoryName.Text;
                fs = new FileStream(@"D:\New Test\prodxml1", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                xml.Serialize(fs, prod);
                MessageBox.Show("done");

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                fs.Close();

            }
        }

        private void button2_XML_Read_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\New Test\prodxml1", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                prod = (Product)xml.Deserialize(fs);
                textBox1_Id.Text = prod.ProdID.ToString();
                textBox2_ProdName.Text = prod.ProdName;
                textBox3_ProdPrice.Text = prod.ProdPrice.ToString();
                textBox4_CategoryName.Text = prod.ProdCategory;                
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void button3_SOAPSerialization_Write_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.ProdID = Convert.ToInt32(textBox1_Id.Text);
                prod.ProdName = textBox2_ProdName.Text;
                prod.ProdPrice = Convert.ToDouble(textBox3_ProdPrice.Text);
                prod.ProdCategory = textBox4_CategoryName.Text;
                fs = new FileStream(@"D:\New Test\prodSoap1", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, prod);
                MessageBox.Show("done");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void button3_SOAP_Read_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\New Test\prodSoap1", FileMode.Open, FileAccess.Read);
               SoapFormatter soap = new SoapFormatter();
                prod = (Product)soap.Deserialize(fs);
                textBox1_Id.Text = prod.ProdID.ToString();
                textBox2_ProdName.Text = prod.ProdName;
                textBox3_ProdPrice.Text = prod.ProdPrice.ToString();
                textBox4_CategoryName.Text = prod.ProdCategory;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void button4_JSONSerialization_Write_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.ProdID = Convert.ToInt32(textBox1_Id.Text);
                prod.ProdName = textBox2_ProdName.Text;
                prod.ProdPrice = Convert.ToDouble(textBox3_ProdPrice.Text);
                prod.ProdCategory = textBox4_CategoryName.Text;
                fs = new FileStream(@"D:\New Test\prodJson1", FileMode.Create, FileAccess.Write);
               
                JsonSerializer.Serialize(fs, prod);
                MessageBox.Show("done");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void button4_Json_Raed_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\New Test\prodJson1", FileMode.Open, FileAccess.Read);
                
                prod = JsonSerializer.Deserialize<Product>(fs);
                textBox1_Id.Text = prod.ProdID.ToString();
                textBox2_ProdName.Text = prod.ProdName;
                textBox3_ProdPrice.Text = prod.ProdPrice.ToString();
                textBox4_CategoryName.Text = prod.ProdCategory;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void button5_Clear_Click(object sender, EventArgs e)
        {
            textBox1_Id.Clear();
            textBox2_ProdName.Clear();
            textBox3_ProdPrice.Clear();
            textBox4_CategoryName.Clear();
        }
    }
}
