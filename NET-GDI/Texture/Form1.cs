using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System;

namespace Ventus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            base.DoubleBuffered = true;
        }

        private readonly Brush brush = new TextureBrush(new Bitmap("images\\tile.jpg"));

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var x = ClientSize.Width / 2;
            var y = ClientSize.Height / 2;
            var r = Math.Min(x, y);
            var p = new PointF[7];
            var a = 0.0;
            for (var i = 0; i < 7; i++)
            {
                p[i] = new PointF((float)(x + r * Math.Cos(a)), (float)(y + r * Math.Sin(a)));
                a += 2 * Math.PI / 7;
            }
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPolygon(brush, p);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
