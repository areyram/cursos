using System;
using System.Collections.Generic;
using System.Threading;

namespace Ventus
{
    internal class Program
    {
        private static readonly Queue<int> queue = new Queue<int>();

        private static void Main()
        {
            const int consumerThreads = 4;

            new Thread(Producer).Start();
            for (var i = 0; i < consumerThreads; i++)
            {
                var thread = new Thread(Consumer);
                thread.Name = "C" + i;
                thread.Start();
            }
        }

        private static void Producer()
        {
            var r = new Random();
            while (true)
            {
                lock (queue)
                {
                    int item = r.Next();
                    queue.Enqueue(item);
                    Thread.Sleep(500);
                    Console.WriteLine("Producer >> {0}", item);
                }
            }
        }

        private static void Consumer()
        {
            while (true)
            {
                int item = 0;
                lock (queue)
                {
                    if (queue.Count != 0)
                        item = queue.Dequeue();
                }
                if (item != 0)
                {
                    Console.WriteLine("{0} >> {1}", Thread.CurrentThread.Name, item);
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
