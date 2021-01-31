using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ventus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            base.DoubleBuffered = true;
        }

        private static readonly Random Rnd = new Random();
        private static readonly Point[] P = new Point[4];
        private static readonly Point[] V = new Point[4];

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            for (var i = 0; i < P.Length; i++)
            {
                P[i].X = Rnd.Next(Width);
                P[i].Y = Rnd.Next(Height);
                V[i].X = Rnd.Next(-5, 5);
                V[i].Y = Rnd.Next(-5, 5);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPolygon(Pens.LightGray, P);
            e.Graphics.DrawBezier(Pens.Blue, P[0].X, P[0].Y, P[1].X, P[1].Y, P[2].X, P[2].Y, P[3].X, P[3].Y);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (var i = 0; i < P.Length; i++)
            {
                P[i].X += V[i].X;
                if (P[i].X < 0 || P[i].X > Width)
                {
                    V[i].X = -V[i].X;
                }
                P[i].Y += V[i].Y;
                if (P[i].Y < 0 || P[i].Y > Height)
                {
                    V[i].Y = -V[i].Y;
                }
            }
            Invalidate();
        }
    }
}
