using System.Text.RegularExpressions;

namespace Ventus
{
    public class TrimPlugin : IPlugin
    {
        private static readonly Regex re = new Regex(@"\s+", RegexOptions.Compiled);

        public string Transform(string text, string mode)
        {
            return re.Replace(text, " ").Trim();
        }

        public string[] Modes
        {
            get { return new string[] { null }; }
        }
    }
}