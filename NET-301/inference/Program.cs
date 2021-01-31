using System;

namespace inference
{
    class Program
    {
        static void Main()
        {
            var i = 100L;
            i = 1000000000000;
            Console.WriteLine(i.GetType());

            object a = new[] {1, 2, 3, 4};
            var o = a as int[];

            var x = 100;
            var y = 200;
        }
    }
}
