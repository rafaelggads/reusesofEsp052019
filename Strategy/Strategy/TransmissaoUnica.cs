using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class TransmissaoUnica : IPreparadorNumeroTransmissoes
    {
        public int prepararAmbienteParaTransmissoesSimultanes()
        {
            return 1;
        }
    }
}
