namespace Ventus
{
    public interface IHandler
    {
        IHandler Successor { get; set; }
        void ProcessRequest(string url);
    }
}
