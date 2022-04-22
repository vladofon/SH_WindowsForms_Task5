using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SH_WindowsForms_Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Picture1 form = new Picture1();
            form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Picture2 form = new Picture2();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Picture3 form = new Picture3();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Picture4 form = new Picture4();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Picture5 form = new Picture5();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Picture6 form = new Picture6();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Picture7 form = new Picture7();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Picture8 form = new Picture8();
            form.Show();
        }
    }
}
