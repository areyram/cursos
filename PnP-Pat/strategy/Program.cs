using System;

namespace Ventus
{
    internal class Program
    {
        private static void Main()
        {
            Test();
        }

        private static void Test()
        {
            var list = new[] { 1, 5, 9, 6, 3, 2, 4, 7, 8 };
            Array.Sort(list, new InOrder());
            PrintList(list);
            Array.Sort(list, new Reverse());
            PrintList(list);
        }

        private static void PrintList(int[] list)
        {
            Console.WriteLine(">>");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
