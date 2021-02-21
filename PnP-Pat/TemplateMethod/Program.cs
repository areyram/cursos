using System;

namespace TemplateMethod
{
    internal class Program
    {
        private static void Main()
        {
            Metodo(new PasosA());
            Metodo(new PasosB());
        }

        //método template
        private static void Metodo(IPasos pasos)
        {
            Console.WriteLine("Inicio");
            pasos.Paso1();
            Console.WriteLine("La parte de enmedio");
            pasos.Paso2();
            Console.WriteLine("Fin");
        }
        
        private interface IPasos
        {
            void Paso1();
            void Paso2();
        }

        private class PasosA : IPasos
        {
            public void Paso1()
            {
                Console.WriteLine("La primera vez hace esto");
            }

            public void Paso2()
            {
                Console.WriteLine("Esto hace adicional #1");
            }
        }

        private class PasosB : IPasos
        {
            public void Paso1()
            {
                Console.WriteLine("La segunda vez hace otra cosa");
            }

            public void Paso2()
            {
                Console.WriteLine("Esto hace adicional #2");
            }
        }

        // = NO =
        //private static void Metodo1(int opcion)
        //{
        //    Console.WriteLine("Inicio");
        //    switch (opcion)
        //    {
        //        case 1:
        //            Console.WriteLine("La primera vez hace esto");
        //            break;
        //        case 2:
        //            Console.WriteLine("La segunda vez hace otra cosa");
        //            break;
        //    }
        //    Console.WriteLine("La parte de enmedio");
        //    switch (opcion)
        //    {
        //        case 1:
        //            Console.WriteLine("Esto hace adicional #1");
        //            break;
        //        case 2:
        //            Console.WriteLine("Esto hace adicional #2");
        //            break;
        //    }
        //    Console.WriteLine("Fin");
        //}
    }
}
