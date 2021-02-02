using System;

namespace Ventus.SqlServer
{
    internal class Cliente : ICliente
    {
        public void Insert()
        {
            Console.WriteLine("SQL Server >> INSERT INTO Cliente");
        }

        public void Update()
        {
            Console.WriteLine("SQL Server >> UPDATE Cliente");
        }
    }
}