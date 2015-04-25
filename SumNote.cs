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
namespace SumNote
{
    public partial class SumNote : Form
    {
        public SumNote()
        {
            InitializeComponent();
        }
        //exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                SaveFileDialog sf = new SaveFileDialog();

                if (sf.ShowDialog() == DialogResult.OK)
                {

                    StreamWriter ob = new StreamWriter(sf.FileName);
                    ob.Write(textBox1.Text);
                    ob.Flush();
                    ob.Close();
                    textBox1.Text = null;
                }
                
            }
            if (textBox1.Text == string.Empty)
            Application.Exit();
        }
        // copy module
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }
        // paste module
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
        // font changing module
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog ob = new FontDialog();
            DialogResult res = ob.ShowDialog();
            if (res == DialogResult.OK)
            {
                string temp = Convert.ToString(textBox1.SelectedText);
                textBox1.Font = ob.Font;
            } 
        }
        //color changing module
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog ob = new ColorDialog();
            DialogResult res = ob.ShowDialog();
            if (res == DialogResult.OK)
                textBox1.ForeColor = ob.Color;
        }
        //Display info
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entropy Developers\nAll Right Reserved!");
        }
        // lower case
        private void toLowerCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           textBox1.SelectedText= textBox1.SelectedText.ToLower();
        }
        //upper case
        private void toUpperCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = textBox1.SelectedText.ToUpper();
        }
        //cut module
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }
        //open file 
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                textBox1.Text=sr.ReadToEnd();
                sr.Close();
            }
        }
        // clear
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
        //Save tool
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            if (sf.ShowDialog() == DialogResult.OK)
            {

                StreamWriter ob = new StreamWriter(sf.FileName);
                ob.Write(textBox1.Text);
                ob.Flush();
                ob.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                //............save the document first...........................
                SaveFileDialog sf = new SaveFileDialog();

                if (sf.ShowDialog() == DialogResult.OK)
                {

                    StreamWriter ob = new StreamWriter(sf.FileName);
                    ob.Write(textBox1.Text);
                    ob.Flush();
                    ob.Close();
                    textBox1.Text = string.Empty;
                }
                
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
