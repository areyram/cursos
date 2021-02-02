using System;
using System.Net;

namespace sample
{
    class Program
    {
        static void Main()
        {
            Test();
        }

        private static void Test()
        {
            WebRequest req;
            req = WebRequest.Create("http://www.nasa.gov/");
            Console.WriteLine(req.GetType());
            req = WebRequest.Create("ftp://ftp.hq.nasa.gov/");
            Console.WriteLine(req.GetType());
        }
    }
}
