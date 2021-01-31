using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            var c = new Cuadrado(100);
            Console.WriteLine(c.Lado);
            Console.WriteLine(c.Perimetro);
        }
    }

    class Cuadrado
    {
        public Cuadrado(int lado)
        {
            Lado = lado;
        }

        public double Lado { get; private set; }

        public double Perimetro
        {
            get { return Lado * 4; }
        }
    }
}
