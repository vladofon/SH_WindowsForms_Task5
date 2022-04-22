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
    public partial class Picture8 : Form
    {
        public Picture8()
        {
            InitializeComponent();
            this.button1.Location = new Point(this.Width / 2 - this.button1.Width / 2, 410);
            this.pictureBox1.Size = new Size(776, 376);
            this.pictureBox1.Location = new Point(12, 12);
            this.button1.Text = "Draw";
            this.label1.Text = "квіткa, що складається з жовтого кола та блакитних еліпсів";
            this.label1.Location = new Point(this.pictureBox1.Width / 2 - this.label1.Width / 2, this.pictureBox1.Height - 20);


            this.pictureBox1.Controls.Add(label1);
            this.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Cyan, 3);
            Pen pen1 = new Pen(Color.Green, 0);

            int width = 100;
            int height = 100;
            int x = pictureBox1.Width / 2 - width / 2;
            int y = pictureBox1.Height / 2 - height / 2;

            Rectangle rect = new Rectangle(x, y, width, height);
            Rectangle rect1 = new Rectangle(x - width * 2, y, width * 2, height);
            Rectangle rect2 = new Rectangle(x + width, y, width * 2, height);

            Point first = new Point(x, y);
            Point second = new Point(x + width / 2, y - (height - height / 2));
            Point third = new Point(x + width, y);
            Point[] points = { first, second, third };


            Brush brush = new SolidBrush(Color.Orange);
            Brush brush1 = new SolidBrush(Color.DarkCyan);
            //Brush brush = new HatchBrush(HatchStyle.LargeCheckerBoard, Color.Black, Color.White);

            Graphics g = pictureBox1.CreateGraphics();
            g.FillEllipse(brush, rect);
            //g.FillEllipse(brush1, rect1);
            //g.FillEllipse(brush1, rect2);

            //g.DrawEllipse(pen, rect);
            for (int i = 0; i < 360; i += 10)
            {
                LineWithAngle((double)i);
            }
        }

        private void LineWithAngle(double angle)
        {
            double length = 100;
            double angleRadians = (Math.PI / 180.0) * angle;
            double x1 = pictureBox1.Width / 2 - 50;
            double y1 = pictureBox1.Height / 2 - 50;
            double x2 = x1 + (Math.Cos(angleRadians) * length);
            double y2 = y1 + (Math.Sin(angleRadians) * length);
            int intX1 = Convert.ToInt32(x1);
            int intY1 = Convert.ToInt32(y1);
            int intX2 = Convert.ToInt32(x2);
            int intY2 = Convert.ToInt32(y2);

            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.pictureBox1.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.CornflowerBlue, 1);

            Rectangle rect = new Rectangle(intX2, intY2, 100, 100);
            graphicsObj.DrawEllipse(myPen, rect);
        }
    }
}
