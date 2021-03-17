using System;

namespace Poltergeist
{
    internal class Program
    {
        private static void Main()
        {
        }
    }

    internal static class Worker
    {
        private static readonly int[] Buffer = new int[1000];

        static Worker()
        {
            Initializer.Fill(Buffer);
        }

        internal static void DoSomething()
        {
            //TODO:
        }

        internal static void DoSomethingElse()
        {
            //TODO:
        }
    }

    //Esta clase solo para esto sirve
    public class Initializer
    {
        public static void Fill(int[] buffer)
        {
            var r = new Random();
            for (var i = 0; i < buffer.Length; i++)
                buffer[i] = r.Next();
        }
    }
}
