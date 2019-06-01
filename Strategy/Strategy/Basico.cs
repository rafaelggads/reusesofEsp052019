using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Basico : IPreco
    {
        public double getCalculaPreco()
        {
            return 21.90;
        }
    }
}
