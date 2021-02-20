namespace Ventus
{
    internal static class Program
    {
        private static void Main()
        {
            IHandler handler = new PlainFileHandler();
            handler = new AspHandler { Successor = handler };
            handler = new AspNetHandler { Successor = handler };
            handler = new PhpHandler { Successor = handler };

            handler.ProcessRequest("index.html");
            handler.ProcessRequest("logo.png");
            handler.ProcessRequest("back.jpg");
            handler.ProcessRequest("styles.css");
            handler.ProcessRequest("default.aspx");
            handler.ProcessRequest("blog.php");
            handler.ProcessRequest("reports.aspx");
            handler.ProcessRequest("chart.png");
        }
    }
}
