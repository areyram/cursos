using System;

namespace CodingByException
{
    internal class Program
    {
        private static void Main()
        {
            Test1A();
            Test1B();

            Test2A();
            Test2B();
        }

        // NO
        private static void Test1A()
        {
            var num = 100;
            var deno = 0;
            try
            {
                var div = num / deno;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: 'deno' no debe ser cero.");
            }
        }

        // YES
        private static void Test1B()
        {
            var num = 100;
            var deno = 0;
            if (deno == 0)
            {
                Console.WriteLine("Error: 'deno' no debe ser cero.");
                return;
            }
            var div = num / deno;
            Console.WriteLine(div);
        }

        // NO
        private static void Test2A()
        {
            var s = "l20";
            try
            {
                var n = Convert.ToInt32(s);
                Console.WriteLine(n);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: 's' no es un entero válido.");
            }
        }

        // YES
        private static void Test2B()
        {
            var s = "l20";
            int n;
            if (int.TryParse(s, out n))
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Error: 's' no es un entero válido.");
            }
        }

    }
}
