using System;

namespace FactoryPatronDiseno
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidaEmbriagante oBebida = Creador.CreadorBebida(Creador.CERVEZA);
            Console.WriteLine(oBebida.CuantoMeEmbriagoPorHora());
        }
    }
}
