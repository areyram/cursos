using System.Windows.Forms;

namespace Ventus
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sample1ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new Form1 { MdiParent = this }.Show();
        }

        private void sample2ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new Form2 { MdiParent = this }.Show();
        }

        private void sample3ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new Form3 { MdiParent = this }.Show();
        }
    }
}
