using System;
using System.Collections.Generic;

namespace SoftCoding
{
    internal class Program
    {
        private static void Main()
        {
            Test1A();
            Test1B();
            Test1C();
        }

        //NO
        private static void Test1A()
        {
            var settings = Settings.Default;
            var fields = new Dictionary<string, int>
            {
                ["Foo"] = 123,
                ["Bar"] = 0,
                ["Bas"] = 321
            };
            if (fields[settings.FieldToCompare] > settings.BaseValue)
                Console.WriteLine(fields[settings.FieldToCompare]);
            else
                Console.WriteLine(fields[settings.ReferenceField]);
        }

        // YES
        private static void Test1B()
        {
            var fields = new
            {
                Foo = 123,
                Bar = 0,
                Bas = 321
            };
            if (fields.Foo > 0)
                Console.WriteLine(fields.Foo);
            else
                Console.WriteLine(fields.Bas);
        }

        // YES
        private static void Test1C()
        {
            var fields = new
            {
                Foo = 123,
                Bar = 0,
                Bas = 321
            };
            Console.WriteLine(fields.Foo > 0 ? fields.Foo : fields.Bas);


            var a = true; var b = true; var c = true; var d = true;
            if (a)
            {
                if ((b || c) & !d)
                {
                    //TODO
                }
            }
        }


    }
}
