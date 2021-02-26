using System;
using System.Collections.Generic;

namespace LoopSwitchSequence
{
    internal class Program
    {
        private static void Main()
        {
            Test1A();
            Test1B();
            Test1C();
        }

        private static void Test1A()
        {
            if (!Step1())
            {
                Console.WriteLine("Interrupted");
                return;
            }
            if (!Step2())
            {
                Console.WriteLine("Interrupted");
                return;
            }
            if (!Step3())
            {
                Console.WriteLine("Interrupted");
                return;
            }
            if (!Step4())
            {
                Console.WriteLine("Interrupted");
                return;
            }
            if (!Step5())
            {
                Console.WriteLine("Interrupted");
                return;
            }
            Console.WriteLine("Done!");
        }

        private static void Test1B()
        {
            for (var step = 0; step < 5; step++)
            {
                bool result = false;
                switch (step)
                {
                    case 0:
                        result = Step1();
                        break;
                    case 1:
                        result = Step2();
                        break;
                    case 2:
                        result = Step3();
                        break;
                    case 3:
                        result = Step4();
                        break;
                    case 4:
                        result = Step5();
                        break;
                }
                if (!result)
                {
                    Console.WriteLine("Interrupted");
                    return;
                }
            }
            Console.WriteLine("Done!");
        }

        private static void Test1C()
        {
            var steps = new List<Func<bool>>
            {
                Step1,
                Step2,
                Step3,
                Step4,
                Step5
            };

            foreach (var step in steps)
            {
                if (!step())
                {
                    Console.WriteLine("Interrupted");
                    return;
                }
            }
            Console.WriteLine("Done!");
        }

        private static bool Step1()
        {
            Console.WriteLine("Step 1");
            return true;
        }

        private static bool Step2()
        {
            Console.WriteLine("Step 2");
            return true;
        }

        private static bool Step3()
        {
            Console.WriteLine("Step 3");
            return false;
        }

        private static bool Step4()
        {
            Console.WriteLine("Step 4");
            return true;
        }

        private static bool Step5()
        {
            Console.WriteLine("Step 5");
            return true;
        }
    }
}
