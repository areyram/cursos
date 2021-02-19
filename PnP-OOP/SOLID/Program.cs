using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 123;
            var s = "Hola";
            var d = new DateTime();
            var o = new Persona { ID = 123, Nombre = "Alex" };
            Console.WriteLine(i.ToString());
            Console.WriteLine(s.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(o.ToString());
        }

        class Persona
        {
            public int ID { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return ID.ToString() + ":" + Nombre;
            }
        }
    }
}
