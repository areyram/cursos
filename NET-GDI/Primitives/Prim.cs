using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Ventus
{
    public partial class Prim : Form
    {
        private readonly Random rnd = new Random();

        public Prim()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DrawLine();
            DrawPolygon();
            DrawRectangle();
            DrawEllipse();
            DrawPie();
            DrawClosedCurve();
            DrawCurve();
            DrawImage();
            DrawArc();
            FillPolygon();
            FillRectangle();
            FillEllipse();
            FillPie();
            FillClosedCurve();
            DrawBezier();
            DrawString();
        }

        private void DrawLine()
        {
            var c = pnlLines;
            var x1 = rnd.Next(c.Width);
            var y1 = rnd.Next(c.Height);
            var x2 = rnd.Next(c.Width);
            var y2 = rnd.Next(c.Height);
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawLine(RandomPen(), x1, y1, x2, y2);
        }

        private void DrawPolygon()
        {
            var c = pnlDrawPolygon;
            var p = new PointF[rnd.Next(5) + 3];
            for (var i = 0; i < p.Length; i++)
                p[i] = new PointF(rnd.Next(c.Width), rnd.Next(c.Height));
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawPolygon(RandomPen(), p);
        }

        private void DrawRectangle()
        {
            var c = pnlDrawRectangle;
            var x = rnd.Next(c.Width);
            var y = rnd.Next(c.Height);
            var w = rnd.Next(c.Width - x);
            var h = rnd.Next(c.Height - y);
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawRectangle(RandomPen(), x, y, w, h);
        }

        private void DrawEllipse()
        {
            var c = pnlDrawEllipse;
            var x = rnd.Next(c.Width);
            var y = rnd.Next(c.Height);
            var w = rnd.Next(c.Width - x);
            var h = rnd.Next(c.Height - y);
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawEllipse(RandomPen(), x, y, w, h);
        }

        private void DrawPie()
        {
            var c = pnlDrawPie;
            var x = rnd.Next(c.Width);
            var y = rnd.Next(c.Height);
            var w = rnd.Next(c.Width - x - 1) + 1;
            var h = rnd.Next(c.Height - y - 1) + 1;
            var a = rnd.Next(360);
            var b = rnd.Next(360 - a) + a;
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawPie(RandomPen(), x, y, w, h, a, b);
        }

        private void DrawClosedCurve()
        {
            var c = pnlDrawClosedCurves;
            var p = new PointF[rnd.Next(5) + 3];
            for (var i = 0; i < p.Length; i++)
                p[i] = new PointF(rnd.Next(c.Width), rnd.Next(c.Height));
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawClosedCurve(RandomPen(), p);
        }

        private void DrawCurve()
        {
            var c = pnlCurves;
            var p = new PointF[rnd.Next(5) + 3];
            for (var i = 0; i < p.Length; i++)
                p[i] = new PointF(rnd.Next(c.Width), rnd.Next(c.Height));
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawCurve(RandomPen(), p);
        }

        private void DrawImage()
        {
            var c = pnlImages;
            var x = rnd.Next(c.Width);
            var y = rnd.Next(c.Height);
            var w = rnd.Next(c.Width - x);
            var h = rnd.Next(c.Height - y);
            var f = Directory.GetFiles("images");
            var i = Image.FromFile(f[rnd.Next(f.Length - 1)]);
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawImage(i, x, y, w, h);
        }

        private void DrawArc()
        {
            var c = pnlArcs;
            var x = rnd.Next(c.Width);
            var y = rnd.Next(c.Height);
            var w = rnd.Next(c.Width - x - 1) + 1;
            var h = rnd.Next(c.Height - y - 1) + 1;
            var a = rnd.Next(360);
            var b = rnd.Next(360 - a) + a;
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawArc(RandomPen(), x, y, w, h, a, b);
        }

        private void FillPolygon()
        {
            var c = pnlFillPolygon;
            var p = new PointF[rnd.Next(5) + 3];
            for (var i = 0; i < p.Length; i++)
                p[i] = new PointF(rnd.Next(c.Width), rnd.Next(c.Height));
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillPolygon(RandomBrush(), p);
        }

        private void FillRectangle()
        {
            var c = pnlFillRectangle;
            var x = rnd.Next(c.Width);
            var y = rnd.Next(c.Height);
            var w = rnd.Next(c.Width - x);
            var h = rnd.Next(c.Height - y);
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillRectangle(RandomBrush(), x, y, w, h);
        }

        private void FillEllipse()
        {
            var c = pnlFillEllipse;
            var x = rnd.Next(c.Width);
            var y = rnd.Next(c.Height);
            var w = rnd.Next(c.Width - x);
            var h = rnd.Next(c.Height - y);
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillEllipse(RandomBrush(), x, y, w, h);
        }

        private void FillPie()
        {
            var c = pnlFillPie;
            var x = rnd.Next(c.Width);
            var y = rnd.Next(c.Height);
            var w = rnd.Next(c.Width - x - 1) + 1;
            var h = rnd.Next(c.Height - y - 1) + 1;
            var a = rnd.Next(360);
            var b = rnd.Next(360 - a) + a;
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillPie(RandomBrush(), x, y, w, h, a, b);
        }

        private void FillClosedCurve()
        {
            var c = pnlFillClosedCurve;
            var p = new PointF[rnd.Next(5) + 3];
            for (var i = 0; i < p.Length; i++)
                p[i] = new PointF(rnd.Next(c.Width), rnd.Next(c.Height));
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillClosedCurve(RandomBrush(), p);
        }

        private void DrawBezier()
        {
            var c = pnlDrawBezier;
            var p = new PointF[4];
            for (var i = 0; i < p.Length; i++)
                p[i] = new PointF(rnd.Next(c.Width), rnd.Next(c.Height));
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawBezier(RandomPen(), p[0], p[1], p[2], p[3]);
        }

        private void DrawString()
        {
            var c = pnlDrawString;
            var x = rnd.Next(c.Width);
            var y = rnd.Next(c.Height);
            var w = rnd.Next(c.Width - x);
            var h = rnd.Next(c.Height - y);
            var g = Graphics.FromHwnd(c.Handle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawString("Lorem ipsum dolor sit amet",
                RandomFont(), RandomBrush(), new RectangleF(x, y, w, h));
        }

        public Pen RandomPen()
        {
            var r = rnd.Next(255);
            var g = rnd.Next(255);
            var b = rnd.Next(255);
            return new Pen(Color.FromArgb(r, g, b));
        }

        public Brush RandomBrush()
        {
            var r = rnd.Next(255);
            var g = rnd.Next(255);
            var b = rnd.Next(255);
            return new SolidBrush(Color.FromArgb(r, g, b));
        }

        public Font RandomFont()
        {
            string name;
            switch (rnd.Next(2))
            {
                case 0:
                    name = "Arial";
                    break;
                case 1:
                    name = "Courier New";
                    break;
                default:
                    name = "Times New Roman";
                    break;
            }
            return new Font(name, (float)(rnd.NextDouble() * 16 + 4));
        }
    }
}