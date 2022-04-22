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
    public partial class Picture4 : Form
    {
        public Picture4()
        {
            InitializeComponent();
            this.button1.Location = new Point(this.Width / 2 - this.button1.Width / 2, 410);
            this.pictureBox1.Size = new Size(776, 376);
            this.pictureBox1.Location = new Point(12, 12);
            this.button1.Text = "Draw";
            this.label1.Text = "будиночок, залитий суцільною кистю із границею";
            this.label1.Location = new Point(this.pictureBox1.Width / 2 - this.label1.Width / 2, this.pictureBox1.Height - 20);


            this.pictureBox1.Controls.Add(label1);
            this.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Cyan, 3);
            Pen pen1 = new Pen(Color.Green, 0);

            int width = 180;
            int height = 180;
            int x = pictureBox1.Width / 2 - width / 2;
            int y = pictureBox1.Height / 2 - height / 4;

            Rectangle rect = new Rectangle(x, y, width, height);

            Point first = new Point(x, y);
            Point second = new Point(x + width / 2, y - (height - height / 2));
            Point third = new Point(x + width, y);
            Point[] points = { first, second, third };

            Brush brush = new SolidBrush(Color.Teal);

            Graphics g = pictureBox1.CreateGraphics();
            g.FillRectangle(brush, rect);
            g.DrawRectangle(pen, rect);
            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
        }
    }
}
