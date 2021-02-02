using System;

namespace Ventus.Oracle
{
    internal class Ciudad : ICiudad
    {
        public void Insert()
        {
            Console.WriteLine("Oracle >> INSERT INTO Ciudad");
        }
    }
}