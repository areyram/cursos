using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ventus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyEffect(c => c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplyEffect(c =>
            {
                var i = (int)(c.GetBrightness() * 255);
                return Color.FromArgb(i, i, i);
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplyEffect(c =>
            {
                var r = c.R & 0xC0;
                var g = c.G & 0xC0;
                var b = c.B & 0xC0;
                return Color.FromArgb(r, g, b);
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplyEffect(c =>
            {
                var r = 255 - c.R;
                var g = 255 - c.G;
                var b = 255 - c.B;
                return Color.FromArgb(r, g, b);
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApplyEffect(c =>
            {
                var r = c.B;
                var g = c.R;
                var b = c.G;
                return Color.FromArgb(r, g, b);
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ApplyEffect(c =>
            {
                var r = c.R * c.R / 256;
                var g = c.G * c.G / 256;
                var b = c.B * c.B / 256;
                return Color.FromArgb(r, g, b);
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ApplyEffect(c =>
            {
                var r = (int)(Math.Sqrt(c.R) * 16);
                var g = (int)(Math.Sqrt(c.G) * 16);
                var b = (int)(Math.Sqrt(c.B) * 16);
                return Color.FromArgb(r, g, b);
            });
        }

        private void ApplyEffect(Func<Color, Color> effect)
        {
            Cursor = Cursors.WaitCursor;
            var bmp = (Bitmap)pictureBox1.Image;
            var cpy = new Bitmap(bmp);
            for (var x = 0; x < bmp.Width; x++)
                for (var y = 0; y < bmp.Height; y++)
                    cpy.SetPixel(x, y, effect(bmp.GetPixel(x, y)));
            pictureBox2.Image = cpy;
            Cursor = Cursors.Default;
        }
    }
}
