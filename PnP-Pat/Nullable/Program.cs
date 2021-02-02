using System;

namespace Ventus
{
    class Program
    {
        static void Main()
        {
            Test1();
            Test2();
        }

        private static void Test1()
        {
            Nullable<int> x;
            x = new Nullable<int>();
            Print1(x);
            x = new Nullable<int>(10);
            Print1(x);
        }

        private static void Print1(Nullable<int> x)
        {
            if (x.HasValue)
                Console.WriteLine("x = " + x.Value);
            else
                Console.WriteLine("x is null");
        }

        private static void Test2()
        {
            int? x;
            x = null;
            Print2(x);
            x = 10;
            Print2(x);
        }

        private static void Print2(int? x)
        {
            if (x != null)
                Console.WriteLine("x = " + (int) x);
            else
                Console.WriteLine("x is null");
        }
    }
}
