using System;

namespace ConsoleGlobal
{
    class Program
    {
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += ErrorHandler;
            Falla();
            Console.WriteLine("Bye.");
        }

        private static void Falla()
        {
            throw new NotImplementedException();
        }

        private static void ErrorHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine("Oops... error. Whatever.");
        }
    }
}
