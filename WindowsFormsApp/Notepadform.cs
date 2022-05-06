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
    public partial class Notepadform : Form
    {
        public Notepadform()
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

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.DefaultExt = ".txt";
                sd.Filter = "Text Document(*.txt)|*.txt|Word(*.docx)|*.docx ";
                DialogResult result = sd.ShowDialog();
                if(result==DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sd.FileName);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();

                }
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Filter= "Text Document(*.txt)|*.txt|Word(*.docx)|*.docx|All File(*.*)|*.* ";
                DialogResult result = od.ShowDialog();
                if(result==DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(od.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void notPadHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
