using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ventus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPixelByPixel_Clicked(object sender, EventArgs e)
        {
            var bmp = new Bitmap("images/landscape.jpg");
            progressBar.Maximum = pictureBox1.Width;
            for (var x = 0; x < pictureBox1.Width; x++)
            {
                for (var y = 0; y < pictureBox1.Height; y++)
                {
                    var c = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y, Color.FromArgb(255, c.G, c.B));
                }
                { progressBar.Value = x; Application.DoEvents(); }
            }
            pictureBox1.Image = bmp;
            progressBar.Value = 0;
        }

        private void btnUnlockBits_Click(object sender, EventArgs e)
        {
            var bmp = new Bitmap("images/landscape.jpg");
            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            var data = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
            var ptr = data.Scan0;
            var n = Math.Abs(data.Stride) * bmp.Height;
            var bytes = new byte[n];
            Marshal.Copy(ptr, bytes, 0, n);
            progressBar.Maximum = bytes.Length;
            for (var i = 2; i < bytes.Length; i += 3)
            {
                bytes[i] = 255;
                if ((i & 0xfff) == 0) { progressBar.Value = i; Application.DoEvents(); }
            }
            Marshal.Copy(bytes, 0, ptr, n);
            bmp.UnlockBits(data);
            pictureBox1.Image = bmp;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "images/landscape.jpg";
        }
    }
}
