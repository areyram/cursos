using System;

namespace Ventus
{
    //Subject
    public static class Client
    {
        public static Action Changed;

        public static void Insert()
        {
            Console.WriteLine("INSERT INTO Client");
            if (Changed != null)
                Changed();
        }

        public static void Update()
        {
            Console.WriteLine("UPDATE Client");
            if (Changed != null)
                Changed();
        }
    }
}