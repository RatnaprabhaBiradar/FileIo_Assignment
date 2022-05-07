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
    public partial class BookInformation : Form
    {
        FileStream fs;
        public BookInformation()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Binary_Write_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.BookId = Convert.ToInt32(textBox1_BookId.Text);
                book.BookName = textBox2_BookName.Text;
                book.BookAuthor = textBox3_AuthorName.Text;
                book.BookPrice = Convert.ToInt32(textBox4_Price.Text);                
                fs = new FileStream(@"D:\New Test\Bookbinary1", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, book);
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

        private void button5_BinarySeralization_Read_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:\New Test\Bookbinary1", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                
                book = (Book)binary.Deserialize(fs);
                textBox1_BookId.Text = book.BookId.ToString();
                textBox2_BookName.Text = book.BookName;
                textBox3_AuthorName.Text = book.BookAuthor;
                textBox4_Price.Text = book.BookPrice.ToString();
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

        private void button2_XmlSeralization_Write_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.BookId = Convert.ToInt32(textBox1_BookId.Text);
                book.BookName = textBox2_BookName.Text;
                book.BookAuthor = textBox3_AuthorName.Text;
                book.BookPrice = Convert.ToInt32(textBox4_Price.Text);
                fs = new FileStream(@"D:\New Test\BookXML1", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                xml.Serialize(fs, book);
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

        private void button6_XmlSeralization_Read_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:\New Test\BookXML1", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                book = (Book)xml.Deserialize(fs);
                textBox1_BookId.Text = book.BookId.ToString();
                textBox2_BookName.Text = book.BookName;
                textBox3_AuthorName.Text = book.BookAuthor;
                textBox4_Price.Text = book.BookPrice.ToString();
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

        private void button3_SoapSeralization_Write_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.BookId = Convert.ToInt32(textBox1_BookId.Text);
                book.BookName = textBox2_BookName.Text;
                book.BookAuthor = textBox3_AuthorName.Text;
                book.BookPrice = Convert.ToInt32(textBox4_Price.Text);
                fs = new FileStream(@"D:\New Test\BookSOAP1", FileMode.Create, FileAccess.Write);
               SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, book);
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

        private void button7_SOAPSEralization_read_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:\New Test\BookSOAP1", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                book = (Book)soap.Deserialize(fs);
                textBox1_BookId.Text = book.BookId.ToString();
                textBox2_BookName.Text = book.BookName;
                textBox3_AuthorName.Text = book.BookAuthor;
                textBox4_Price.Text = book.BookPrice.ToString();
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

        private void button4_JsonSeralization_Write_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.BookId = Convert.ToInt32(textBox1_BookId.Text);
                book.BookName = textBox2_BookName.Text;
                book.BookAuthor = textBox3_AuthorName.Text;
                book.BookPrice = Convert.ToInt32(textBox4_Price.Text);
                fs = new FileStream(@"D:\New Test\BookJson1", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, book);
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

        private void button8_JsonSeralization_Read_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:\New Test\BookJson1", FileMode.Open, FileAccess.Read);                
                book = JsonSerializer.Deserialize<Book>(fs);
                textBox1_BookId.Text = book.BookId.ToString();
                textBox2_BookName.Text = book.BookName;
                textBox3_AuthorName.Text = book.BookAuthor;
                textBox4_Price.Text = book.BookPrice.ToString();
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

        private void button9_Clear_Click(object sender, EventArgs e)
        {
            textBox1_BookId.Clear();
            textBox2_BookName.Clear();
            textBox3_AuthorName.Clear();
            textBox4_Price.Clear();
        }
    }
    
}
