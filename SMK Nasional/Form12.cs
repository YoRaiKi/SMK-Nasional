using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMK_Nasional
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14(); 
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form14 form2 = new Form14();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13();
            form.ShowDialog();
        }
    }
}
