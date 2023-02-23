using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wintest_ivailo
{
    public partial class knijarnica : Form
    {
        public knijarnica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string txtavtor = "";
            string txtzaglavie = "";
            string cmbizdatelstvo = "";
            string rbhudojestvena = "";
            string rbnauchna = "";
            string rbspravochna = "";
            if (string.IsNullOrEmpty(txtavtor))
            {
                MessageBox.Show("ne si vuvel avtor");
            }   
            else 
            
            if (string.IsNullOrEmpty(txtzaglavie)) 
            {
                MessageBox.Show("ne si vuvel zaglavie");
            }
            else
            if (string.IsNullOrEmpty(cmbizdatelstvo))
            {
                MessageBox.Show("ne si izbral izdatelstvo");
            }
           
           

        }
    }
}
