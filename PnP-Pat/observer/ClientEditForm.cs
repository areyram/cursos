using System;

namespace Ventus
{
    //Observer
    public class ClientEditForm
    {
        public ClientEditForm()
        {
            City.Changed += RefreshCombo;
            RefreshCombo();
        }

        public void RefreshCombo()
        {
            Console.WriteLine("COMBO <- SELECT FROM City");
        }
    }
}
