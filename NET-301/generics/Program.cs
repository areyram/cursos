using System;
using System.Collections.Generic;

namespace Ventus
{
    class Program
    {
        static void Main()
        {
            var a = new List<string>
            {
                "uno",
                "dos",
                "tres",
                "cuatro",
                "cinco"
            };
            Util.SelectionSort(a);
            foreach (var s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}
