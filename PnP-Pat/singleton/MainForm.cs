using System;
using System.Windows.Forms;

namespace singleton
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuRegular_Click(object sender, EventArgs e)
        {
            ShowForm(new RegularForm());
        }

        private void mnuSingleton_Click(object sender, EventArgs e)
        {
            //ShowForm(new SingletonForm());
            ShowForm(SingletonForm.Instance);
        }

        private void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }
    }
}
