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
        }

        private void PensBrushes_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var pen = new Pen(Color.Blue)
            {
                Width = 10,
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                DashCap = DashCap.Triangle,
                DashStyle = DashStyle.Custom,
                DashPattern = new[] {1F, 2F, 3F, 4F, 5F, 1F}
            };
            g.DrawLine(pen, 100, 100, 300, 300);
        }
    }
}
