using System;
using System.Drawing;

namespace Ventus
{
    class Program
    {
        static void Main()
        {
            var p = new Point(100, 50);
            Console.WriteLine(Util.DistanceToOrigin(p));
            Console.WriteLine(p.DistanceToOrigin());
            Console.WriteLine(Extension.DistanceToOrigin(p));
        }
    }
}
