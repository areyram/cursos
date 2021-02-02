using System;

namespace Ventus.Oracle
{
    internal class Cliente : ICliente
    {
        public void Insert()
        {
            Console.WriteLine("Oracle >> INSERT INTO Cliente");
        }

        public void Update()
        {
            Console.WriteLine("Oracle >> UPDATE Cliente");
        }
    }
}