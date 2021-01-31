using System.Windows.Forms;

namespace Ventus
{
    public partial class MainForm : Form
    {
        private int _value;

        public MainForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            progressPie.Value = _value;
            _value++;
            if (_value > 100) _value = 0;
        }

        private void gradientButton1_Click(object sender, System.EventArgs e)
        {
            timer.Start();
        }

        private void gradientButton2_Click(object sender, System.EventArgs e)
        {
            timer.Stop();
        }
    }
}
