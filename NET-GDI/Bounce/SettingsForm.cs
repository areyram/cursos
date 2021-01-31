using System;
using System.Windows.Forms;
using Ventus.Properties;

namespace Ventus
{
    public partial class SettingsForm : Form
    {
        internal static bool Cancelled;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var s = Settings.Default;
            nudN.Value = s.N;
            nudRadius.Value = (decimal)s.Radius;
            nudGravity.Value = (decimal)s.Gravity;
            nudRestitution.Value = (decimal)s.Restitution;
            nudFriction.Value = (decimal)s.Friction;
            Cancelled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var s = Settings.Default;
            s.N = (int)nudN.Value;
            s.Radius = (float)nudRadius.Value;
            s.Gravity = (float)nudGravity.Value;
            s.Restitution = (float)nudRestitution.Value;
            s.Friction = (float)nudFriction.Value;
            s.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }
    }
}
