using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class BatchInfoBinaryReaderWriter : Form
    {
        FileStream fs;
        public BatchInfoBinaryReaderWriter()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Binary_Writer_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\New Test\Book Information.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(textBox6_BatchID.Text));
                bw.Write(textBox5_BatchName.Text);
                bw.Write(textBox4_StartDate.Text);
                bw.Write(textBox3_EndDate.Text);
                bw.Write(textBox2_Batch_Location.Text);
                bw.Write(textBox1_Trainer_Name.Text);
                MessageBox.Show("Done");
                bw.Close();
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

        private void button2_Binary_Reader_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\New Test\Book Information.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBox6_BatchID.Text = br.ReadInt32().ToString();
                textBox5_BatchName.Text = br.ReadString();
                textBox4_StartDate.Text= br.ReadString();
                textBox3_EndDate.Text = br.ReadString();
                textBox2_Batch_Location.Text = br.ReadString();
                textBox1_Trainer_Name.Text = br.ReadString();
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

        private void button1_Clear_Click(object sender, EventArgs e)
        {
            textBox1_Trainer_Name.Clear();
            textBox2_Batch_Location.Clear();
            textBox3_EndDate.Clear();
            textBox4_StartDate.Clear();
            textBox5_BatchName.Clear();          
            textBox6_BatchID.Clear();

        }
    }
    
}
