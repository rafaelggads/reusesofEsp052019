using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Solucao_Professor
{
    interface IEstacao
    {
        void register(Interessado interessado);
        void unregister(Interessado interessado);
        void notificar();
    }
}
