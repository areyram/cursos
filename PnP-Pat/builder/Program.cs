using System;

namespace Ventus
{
    internal class Program
    {
        public static void Main()
        {
            Test();
        }

        private static void Test()
        {
            var newManufacturer = new Manufacturer();

            IPhoneBuilder phoneBuilder;

            phoneBuilder = new AndroidPhoneBuilder();
            newManufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new Phone built:\n\n{0}", phoneBuilder.Phone);

            phoneBuilder = new WindowsPhoneBuilder();
            newManufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new Phone built:\n\n{0}", phoneBuilder.Phone);
        }
    }
}
