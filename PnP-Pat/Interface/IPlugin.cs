namespace Ventus
{
    public interface IPlugin
    {
        string Transform(string text, string mode);
        string[] Modes { get; }
    }
}
