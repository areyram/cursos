namespace Ventus.SqlServer
{
    internal class Factory : IFactory
    {
        public ICliente CreateCliente()
        {
            return new Cliente();
        }

        public ICiudad CreateCiudad()
        {
            return new Ciudad();
        }
    }
}