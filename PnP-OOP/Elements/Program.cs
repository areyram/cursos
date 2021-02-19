//using System;
//using System.Linq;

//namespace Ventus
//{
//    internal class Program
//    {
//        private static void Main()
//        {
//            Example1();
//            Example2();
//            Example3();
//        }

//        private static void Example1()
//        {
//            //Say what you mean, simply and directly.
//            //Use library functions whenever feasible.
//            //Don't sacrifice clarity for small gains in efficiency.

//            var list = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            //NO
//            {
//                var sum = 0;
//                for (var i = 0; i < list.Length; i++)
//                    if ((i & 1) == 0)
//                        sum += list[i];
//            }

//            //YES
//            {
//                var sum = list.Where(o => o % 2 == 0).Sum();
//            }
//        }

//        private static void Example2()
//        {
//            // Make sure special cases are truly special.

//            var x = new Random().Next();
//            var y;

//            //NO
//            {
//                if (x == 0)
//                    y = 0;
//                else if (x == 1)
//                    y = 100;
//                else
//                    y = 100 * x;
//            }

//            //YES
//            {
//                y = 100 * x;
//            }
//        }

//        private static void Example3()
//        {
//            // Keep it simple to make it faster.

//            var a = 1.0;
//            var b = 2.0;
//            var c = 3.0;

//            //NO
//            {
//                var x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
//                var x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
//            }

//            //YES
//            {
//                var s = Math.Sqrt(b * b - 4 * a * c);
//                var d = 2 * a;
//                var x1 = (-b + s) / d;
//                var x2 = (-b - s) / d;
//            }
//        }
//    }
//}
