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

namespace WindowsFormsApp
{
    public partial class Serilization_DEPT : Form
    {
        public Serilization_DEPT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button3_CreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\New Test";
                if(Directory.Exists(path))
                {
                    MessageBox.Show("Folder already Present");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");

                }

            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void button4_CreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\New Test\My Fist File.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File already Present");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created");

                }

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        FileStream fs;
        private void button1_Write_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\New Test\My Fist File.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(Convert.ToInt32(textBox1_DeptId.Text));
                bw.Write(textBox2_Name.Text);
                bw.Write(textBox3_Location.Text);
                bw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void button2_Read_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\New Test\My Fist File.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBox1_DeptId.Text = br.ReadInt32().ToString();
                textBox2_Name.Text = br.ReadString();
                textBox3_Location.Text = br.ReadString();
                br.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1_DeptId.Clear();
            textBox2_Name.Clear();
            textBox3_Location.Clear();
        }

        

        private void button2_BinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                fs = new FileStream(@"D:\New Test\dept", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                dept = (Department)binary.Deserialize(fs);
                textBox1_DeptId.Text = dept.Id.ToString();
                textBox2_Name.Text = dept.Name;
                textBox3_Location.Text = dept.Location;
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

        private void button1_binaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(textBox1_DeptId.Text);
                dept.Name = textBox2_Name.Text;
                dept.Location = textBox3_Location.Text;
                fs = new FileStream(@"D:\New Test\dept", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, dept);
                MessageBox.Show("Done");
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                fs.Close();

            }

        }
    }
}
