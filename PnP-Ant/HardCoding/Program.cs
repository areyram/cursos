using System;

namespace HardCoding
{
    internal class Program
    {
        private static void Main()
        {
            Test1A(true);
            Test1A(false);
            Test1B(true);
            Test1B(false);
            Test1C(true);
            Test1C(false);
        }

        //NO
        private static void Test1A(bool ivaIncluido)
        {
            var monto = 1000m;
            decimal total;
            decimal subtotal;
            decimal iva;
            if (ivaIncluido)
            {
                total = monto;
                subtotal = monto / 1.15m;
                iva = total - subtotal;
            }
            else
            {
                subtotal = monto;
                iva = subtotal * 0.15m;
                total = subtotal + iva;
            }
            Console.WriteLine($"{subtotal:C} + {iva:C} = {total:C}");
        }

        //YES
        
        private static void Test1B(bool ivaIncluido)
        {
            var monto = 1000m;
            decimal total;
            decimal subtotal;
            decimal iva;
            var percentIva = Settings.Default.PercentIva;
            if (ivaIncluido)
            {
                total = monto;
                subtotal = monto / (1 + percentIva);
                iva = total - subtotal;
            }
            else
            {
                subtotal = monto;
                iva = subtotal * percentIva;
                total = subtotal + iva;
            }
            Console.WriteLine($"{subtotal:C} + {iva:C} = {total:C}");
        }

        //YES
        private static void Test1C(bool ivaIncluido)
        {
            var monto = 1000m;
            decimal total;
            decimal subtotal;
            decimal iva;
            var pIva = DAC.Settings.Get<decimal>("PercentIva");
            if (ivaIncluido)
            {
                total = monto;
                subtotal = monto / (1 + pIva);
                iva = total - subtotal;
            }
            else
            {
                subtotal = monto;
                iva = subtotal * pIva;
                total = subtotal + iva;
            }
            Console.WriteLine($"{subtotal:C} + {iva:C} = {total:C}");
        }

        #region Mock

        private static class DAC
        {
            public static class Settings
            {
                public static T Get<T>(string name)
                {
                    return (T)(object)0.15m;
                }
            }
        }

        #endregion
    }
}
