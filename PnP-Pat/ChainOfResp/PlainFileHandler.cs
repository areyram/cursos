using System;

namespace Ventus
{
    class PlainFileHandler : IHandler
    {
        public IHandler Successor { get; set; }

        public void ProcessRequest(string url)
        {
            Console.WriteLine("{0} >> {1}", GetType().Name, url);
        }
    }
}
