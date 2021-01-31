using System;

namespace partial
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new Ejemplo().X);
        }
    }


    public partial class Ejemplo
    {
        public int X;
    }

    partial class Ejemplo
    {
        public int x;
        public int Y;
    }
}
