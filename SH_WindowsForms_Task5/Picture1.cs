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
    public partial class Picture1 : Form
    {
        public Picture1()
        {
            InitializeComponent();
            this.button1.Location = new Point(this.Width / 2 - this.button1.Width / 2, 410);
            this.label1.Location = new Point(this.pictureBox1.Width / 2 - this.label1.Width / 2, this.pictureBox1.Height - 20);

            this.pictureBox1.Controls.Add(label1);
            this.Controls.Add(button1);
        }

        private void Picture1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);

            int width = 500;
            int height = 250;
            int x = pictureBox1.Width / 2 - width / 2;
            int y = pictureBox1.Height / 2 - height / 2;

            Rectangle rect = new Rectangle(x, y, width, height);

            Brush brush = new SolidBrush(Color.Teal);

            Graphics g = pictureBox1.CreateGraphics();
            g.FillRectangle(brush, rect);
        }
    }
}
