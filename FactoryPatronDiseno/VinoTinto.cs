using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatronDiseno
{
    class VinoTinto : BebidaEmbriagante
    {
        public override int CuantoMeEmbriagoPorHora()
        {
            return 20;
        }
    }
}
