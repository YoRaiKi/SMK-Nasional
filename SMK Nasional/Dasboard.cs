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
    public partial class Dasboard : Form
    {
        public Dasboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterData form = new MasterData();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10(); 
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11(); 
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12(); 
            form.ShowDialog();
        }
    }
}
