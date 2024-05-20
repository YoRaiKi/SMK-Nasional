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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 ur = new Form16();
            ur.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 hu = new Form15();
            hu.ShowDialog();
        }
    }
}
