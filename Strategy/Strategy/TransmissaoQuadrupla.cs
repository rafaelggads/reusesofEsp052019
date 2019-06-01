using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class TransmissaoQuadrupla : IPreparadorNumeroTransmissoes
    {
        public int prepararAmbienteParaTransmissoesSimultanes() 
        {
            return 4;
        }
    }
}
