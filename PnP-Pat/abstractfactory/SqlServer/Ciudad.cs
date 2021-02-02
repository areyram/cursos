using System;

namespace Ventus.SqlServer
{
    internal class Ciudad : ICiudad
    {
        public void Insert()
        {
            Console.WriteLine("SQL Server >> INSERT INTO Ciudad");
        }
    }
}