using System;
using System.Collections.Generic;

namespace sample
{
    internal class Program
    {
        private static void Main()
        {
            Test0();
            Test1();
            Test2();
            Test3();
        }

        private static void Test0()
        {
            //TODO:
            throw new NotImplementedException();
        }

        private static void Test1()
        {
            var values = new[] { 1, 2, 3, 4, 5 };
            foreach (var i in values)
            {
                Console.WriteLine(i);
            }
        }

        private static void Test2()
        {
            var values = new[] { 1, 2, 3, 4, 5 };
            var e = values.GetEnumerator();
            while (e.MoveNext())
            {
                int i = (int)e.Current;
                Console.WriteLine(i);
            }
        }

        private static void Test3()
        {
            var values = new[] { 1, 2, 3, 4, 5 };
            var e = ((IEnumerable<int>)values).GetEnumerator();
            while (e.MoveNext())
            {
                int i = e.Current;
                Console.WriteLine(i);
            }
        }
    }
}
