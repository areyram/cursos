using System;

namespace Ventus
{
    internal class Program
    {
        private static void Main()
        {
            IFactory factory;

            Console.WriteLine("1. Oracle");
            Console.WriteLine("2. SQL Server");
            Console.WriteLine();
            Console.Write("Provider? ");
            string s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    factory = new Oracle.Factory();
                    break;
                case "2":
                    factory = new SqlServer.Factory();
                    break;
                default:
                    return;
            }
            ICliente cliente = factory.CreateCliente();
            cliente.Insert();
            cliente.Update();
            ICiudad ciudad = factory.CreateCiudad();
            ciudad.Insert();
        }
    }
}
