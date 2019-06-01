using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Padrao : IPreco
    {
        public double getCalculaPreco()
        {
            return 32.90;
        }
    }
}
