namespace initializer
{
    class Program
    {
        static void Main()
        {
            var o = new Ciudad
            {
                Nombre = "Monterrey",
                Estado = new Estado { ID = 1 }
            };

        }
    }

    internal class Estado
    {
        public int ID { get; set; }
    }

    internal class Ciudad
    {
        public string Nombre { get; set; }
        public Estado Estado { get; set; }
    }
}
