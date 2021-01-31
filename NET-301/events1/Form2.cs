using System;
using System.Windows.Forms;

namespace Ventus
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			button1.Click += button1_Click;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hey ya");
		}

		private int button1_Click()
		{
			MessageBox.Show("Not it");
			return 0;
		}
	}
}
