using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp
{
    public partial class StudentForm : Form
    {
        FileStream fs;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_WriteFile_Click(object sender, EventArgs e)
        {
            try
            {

                fs = new FileStream(@"D:\New Test\My Student Information.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(textBox1_RollNo.Text));
                bw.Write(textBox2_Name.Text);
                bw.Write(textBox3_Email.Text);
                bw.Write(Convert.ToInt64(textBox4_ContactNo.Text));
                bw.Write(textBox5_Bdate.Text);
                bw.Write(textBox6_City.Text);
                bw.Close();
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

        private void button2_Read_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\New Test\My Student Information.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                textBox1_RollNo.Text = br.ReadInt32().ToString();
                textBox2_Name.Text = br.ReadString();
                textBox3_Email.Text = br.ReadString();
                textBox4_ContactNo.Text = br.ReadInt64().ToString();
                textBox5_Bdate.Text = br.ReadString();
                textBox6_City.Text = br.ReadString();
                br.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1_RollNo.Clear();
            textBox2_Name.Clear();
            textBox3_Email.Clear();
            textBox4_ContactNo.Clear();
            textBox5_Bdate.Clear();
            textBox6_City.Clear();
        }
    }
}
