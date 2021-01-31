using System;
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
			button1.Click += new EventHandler(button1_Click);
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
