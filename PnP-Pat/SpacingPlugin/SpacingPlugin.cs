using System;
using System.Text.RegularExpressions;

namespace Ventus
{
    public class SpacingPlugin : IPlugin
    {
        private static readonly Regex re = new Regex(@"\s+", RegexOptions.Compiled);

        public string Transform(string text, string mode)
        {
            string space;
            switch (mode)
            {
                case "Single space":
                    space = " ";
                    break;
                case "Double space":
                    space = "  ";
                    break;
                case "No space":
                    space = "";
                    break;
                default:
                    return text;
            }
            return re.Replace(text, space);
        }

        public string[] Modes
        {
            get { return new string[] { "Single space", "Double space", "No space" }; }
        }
    }
}
