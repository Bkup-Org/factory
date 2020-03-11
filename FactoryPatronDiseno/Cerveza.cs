using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatronDiseno
{
    class Cerveza : BebidaEmbriagante
    {
        public override int CuantoMeEmbriagoPorHora()
        {
            return 5;
        }
    }
}
