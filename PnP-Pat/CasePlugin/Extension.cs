using System.Linq;
using System.Text.RegularExpressions;

namespace Ventus
{
    internal static class Extension
    {
        private static readonly Regex re = new Regex(@"([a-z]+|[^a-z]+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        internal static string WordCase(this string s)
        {
            return string.Join(string.Empty,
                re.Matches(s).Cast<Match>().Select(o => char.IsLetter(o.Value.First()) ? o.Value.Capitalize() : o.Value));
        }

        internal static string Capitalize(this string s)
        {
            return char.ToUpper(s.First()) + s.Substring(1).ToLower();
        }
    }
}
