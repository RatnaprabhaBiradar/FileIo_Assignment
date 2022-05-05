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
    public partial class EmployeeForm : Form
    {
        FileStream fs;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void button1_WriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\New Test\My Employee Information.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(textBox1_EmpId.Text));
                bw.Write(textBox2_Name.Text);
                bw.Write(textBox3_EmpelailId.Text);
                bw.Write(textBox4_Bdate.Text);
                bw.Write(textBox5_JoiningDate.Text);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_ReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\New Test\My Employee Information.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBox1_EmpId.Text = br.ReadInt32().ToString();
                textBox2_Name.Text = br.ReadString();
                textBox3_EmpelailId.Text = br.ReadString();
                textBox4_Bdate.Text = br.ReadString();
                textBox5_JoiningDate.Text = br.ReadString();
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

        private void button3_Clear_Click(object sender, EventArgs e)
        {
            textBox1_EmpId.Clear();
            textBox2_Name.Clear();
            textBox3_EmpelailId.Clear();
            textBox4_Bdate.Clear();
            textBox5_JoiningDate.Clear();

        }
    }
}
