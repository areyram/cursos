using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace parse
{
    class Program
    {
        static void Main()
        {
            var fechas = "10:30 AM 12:00 PM 02:15 PM 04:30 PM";
            var re = new Regex(@"\d{2}:\d{2} (A|P)M");
            Console.WriteLine(string.Join(" ",
                re.Matches(fechas)
                    .Cast<Match>()
                    .Select(s => DateTime.Parse(s.Value).ToString("HH:mm"))));
        }
    }
}
