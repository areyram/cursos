using System;

namespace Ventus
{
    //Observer
    public class ClientListForm
    {
        public ClientListForm()
        {
            Client.Changed += RefreshGrid;
            City.Changed += RefreshGrid;
            RefreshGrid();
        }

        private static void RefreshGrid()
        {
            Console.WriteLine("GRID <- SELECT FROM Client JOIN City");
        }
    }
}