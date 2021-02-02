using System;
using System.IO;

namespace Ventus
{
    class PhpHandler : IHandler
    {
        public IHandler Successor { get; set; }

        public void ProcessRequest(string url)
        {
            if (Path.GetExtension(url) == ".php")
                Console.WriteLine("{0} >> {1}", GetType().Name, url);
            else
                Successor.ProcessRequest(url);
        }
    }
}
