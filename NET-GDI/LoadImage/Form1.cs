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

        private void LoadImage_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("images\\drawing.png");
            pictureBox2.Image = Image.FromFile("images\\drawing.wmf");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(pictureBox2.Size.Width / 2, pictureBox2.Size.Height / 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Size.Width * 2, pictureBox1.Size.Height * 2);
        }
    }
}
