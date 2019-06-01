using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class TransmissaoDupla : IPreparadorNumeroTransmissoes
    {
        public int prepararAmbienteParaTransmissoesSimultanes()
        {
            return 2;
        }
    }
}
