using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Calcule l'ecart moyen
        /// </summary>
        public void ecartMoyen()
        {
            #region SplitNumbers
            char[] delimiterChars = { ' ' };

            string values = richTextBox1.Text;
        //  MessageBox.Show($"\n\tOriginal values: {values}", "");

            string[] numberCount = values.Split(delimiterChars);
        //  MessageBox.Show("{0} words in textbox", wordCount.Length);
            
            foreach (string s in numberCount)
            {
                Convert.ToDouble(s);
            //  MessageBox.Show(s, s); //verify if values were correctly converted to double
            }
            #endregion
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sortieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            ecartMoyen();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string values = richTextBox1.Text;
        }
    }
}
