using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SH_WindowsForms_Task5
{
    public partial class Picture6 : Form
    {
        public Picture6()
        {
            InitializeComponent();
            this.button1.Location = new Point(this.Width / 2 - this.button1.Width / 2, 410);
            this.pictureBox1.Size = new Size(776, 376);
            this.pictureBox1.Location = new Point(12, 12);
            this.button1.Text = "Draw";
            this.label1.Text = "6-тигранна зірка, контур штриховою лінією, залита суцільною кистю";
            this.label1.Location = new Point(this.pictureBox1.Width / 2 - this.label1.Width / 2, this.pictureBox1.Height - 20);


            this.pictureBox1.Controls.Add(label1);
            this.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 20);
            Pen pen1 = new Pen(Color.White, 0);

            int width = 200;
            int height = 200;
            int widthCover = 250;
            int heightCover = 250;
            int x = pictureBox1.Width / 2 - width / 2;
            int y = pictureBox1.Height / 2 + height / 3;
            int xCover = pictureBox1.Width / 2 - widthCover / 2;
            int yCover = pictureBox1.Height / 2 + heightCover / 3;

            Rectangle rect = new Rectangle(x, y, width, height);

            Point t1first = new Point(x, y);
            Point t1second = new Point(x + width / 2, y - ((int)(Math.Sqrt(height * height - height / 2 * height / 2))));
            Point t1third = new Point(x + width, y);
            Point[] points1 = { t1first, t1second, t1third };

            Point t2first = new Point(x, y - height / 2 - height / 12);
            Point t2second = new Point(x + width / 2, y + ((int)(Math.Sqrt(height * height - height / 2 * height / 2))) - height / 2 - height / 12);
            Point t2third = new Point(x + width, y - height / 2 - height / 12);
            Point[] points2 = { t2first, t2second, t2third };

            Point t3first = new Point(xCover, yCover);
            Point t3second = new Point(xCover + widthCover / 2, yCover - ((int)(Math.Sqrt(heightCover * heightCover - heightCover / 2 * heightCover / 2))));
            Point t3third = new Point(xCover + widthCover, yCover);
            Point[] points3 = { t3first, t3second, t3third };

            Point t4first = new Point(xCover, yCover - heightCover / 2 - heightCover / 12);
            Point t4second = new Point(xCover + widthCover / 2, yCover + ((int)(Math.Sqrt(heightCover * heightCover - heightCover / 2 * heightCover / 2))) - heightCover / 2 - heightCover / 12);
            Point t4third = new Point(xCover + widthCover, yCover - heightCover / 2 - heightCover / 12);
            Point[] points4 = { t4first, t4second, t4third };

            Brush brush = new SolidBrush(Color.White);
            Brush brush1 = new HatchBrush(HatchStyle.BackwardDiagonal, Color.White, Color.Blue);

            Graphics g = pictureBox1.CreateGraphics();

            g.FillPolygon(brush1, points3);

            g.FillPolygon(brush1, points4);

            g.FillPolygon(brush, points1);

            g.FillPolygon(brush, points2);
        }
    }
}
