namespace Ventus
{
    public class CasePlugin : IPlugin
    {
        public string Transform(string text, string mode)
        {
            switch (mode)
            {
                case "Uppercase":
                    return text.ToUpper();
                case "Lowercase":
                    return text.ToLower();
                case "Word Case":
                    return text.WordCase();
                default:
                    return text;
            }
        }

        public string[] Modes
        {
            get { return new[] { "Uppercase", "Lowercase", "Word Case" }; }
        }
    }
}
