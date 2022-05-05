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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontd = new FontDialog();
            DialogResult result = fontd.ShowDialog();
            if(result==DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontd.Font;
            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colord = new ColorDialog();
            DialogResult result = colord.ShowDialog();
            if (result==DialogResult.OK)
            {
                richTextBox1.SelectionColor = colord.Color;
            }
        }
    }
}
