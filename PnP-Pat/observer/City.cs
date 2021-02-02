using System;

namespace Ventus
{
    //Subject
    public static class City
    {
        public static Action Changed;

        public static void Insert()
        {
            Console.WriteLine("INSERT INTO City");
            if (Changed != null)
                Changed();
        }

        public static void Update()
        {
            Console.WriteLine("UPDATE City");
            if (Changed != null)
                Changed();
        }
    }
}
