using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Show_Click(object sender, EventArgs e)
        {
            
          // MessageBox.Show($"Name={textBox1_Name.Text}\nEmail Id={textBox2_EmailId.Text}\nContact Number={textBox3_CNumber.Text}\nAddress={textBox4_Address.Text}");
            label_showDetails.Text=($"Name={textBox1_Name.Text} \nEmail Id={textBox2_EmailId.Text}\nContact Number={textBox3_CNumber.Text}\nAddress={textBox4_Address.Text}");
        }

        private void button2_Clear_Click(object sender, EventArgs e)
        {
            textBox1_Name.Clear();
            textBox2_EmailId.Clear();
            textBox3_CNumber.Clear();
            textBox4_Address.Clear();
        }
    }
}
