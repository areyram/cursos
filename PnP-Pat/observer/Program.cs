using System;

namespace Ventus
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var f1 = new ClientListForm();
            var f2 = new ClientEditForm();
            Client.Insert();
            Client.Update();
            City.Update();
        }
    }
}
