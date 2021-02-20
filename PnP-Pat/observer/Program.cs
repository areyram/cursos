using System;

namespace Ventus
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            var f1 = new ClientListForm();
            var f2 = new ClientEditForm();
            Client.Insert();
            Client.Update();
            City.Update();
        }
    }
}
