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
    public class Book
    {
       
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public int BookPrice { get; set; }

    }
    class TestBook
    {
        static void Main(string[] args)
        {
            FileStream fs;
            Book[] book = new Book[]
            {
               new Book{ BookId = 0121, BookName = "Learning C#", BookAuthor = "Microsoft", BookPrice = 2000 },
               new Book{ BookId = 0122, BookName = "Learning VB", BookAuthor = "Microsoft", BookPrice = 3000 },
               new Book{ BookId = 0123, BookName = "Learning .net", BookAuthor = "Microsoft", BookPrice = 4000 },

            };
            //Binary write serilization
            try
            {
                for (int i = 0; i < book.Length; i++)
                {
                    fs = new FileStream($@"D:\New Test\Book\BookBinary{i}", FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, book[i]);
                    MessageBox.Show("Binary Serilization Successful");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Book book1 = new Book() { BookId = 0121, BookName = "Learning C#", BookAuthor = "Microsoft", BookPrice = 2000 };
            //serilization Using XML
            try
            {               
                fs = new FileStream(@"D:\New Test\BookXML", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                xml.Serialize(fs, book1);
                MessageBox.Show("XML Serilization");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //serilization Using XML
            try
            {
                fs = new FileStream(@"D:\New Test\BookSOAP", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, book1);
                MessageBox.Show("Soap Serilization");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Json Serilization Write/Store
            try
            {
                fs = new FileStream(@"D:\New Test\BookJson", FileMode.Create, FileAccess.Write);
                
                JsonSerializer.Serialize(fs, book1);
                MessageBox.Show("Json Serilization");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
