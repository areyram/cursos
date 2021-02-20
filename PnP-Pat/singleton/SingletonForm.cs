using System.Windows.Forms;

namespace Ventus
{
    public partial class SingletonForm : Form
    {
        private SingletonForm()
        {
            InitializeComponent();
        }

        private static SingletonForm _instance;

        public static SingletonForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SingletonForm();
                return _instance;
            }
        }

        private void SingletonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
