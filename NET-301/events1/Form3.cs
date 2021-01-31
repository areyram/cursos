using System;
using System.Windows.Forms;

namespace Ventus
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += (o, args) => MessageBox.Show("Hey ya");
        }

        private int button1_Click()
        {
            MessageBox.Show("Not it");
            return 0;
        }
    }
}
