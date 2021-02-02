namespace Ventus
{
    internal interface IFactory
    {
        ICliente CreateCliente();
        ICiudad CreateCiudad();
    }
}