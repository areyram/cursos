using System;
using System.Threading;
using System.Windows.Forms;

namespace sample1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.ThreadException += ErrorHandler;
            Application.Run(new Form1());
        }

        private static void ErrorHandler(object sender, ThreadExceptionEventArgs e)
        {
            if (MessageBox.Show("Oops... algo salió mal. Nos vamos o que?", "Error",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                Application.Exit();
            else if (MessageBox.Show("Quieres ver el mensaje de error?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MessageBox.Show(e.Exception.ToString());
        }
    }
}
