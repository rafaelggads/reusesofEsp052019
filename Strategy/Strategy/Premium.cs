using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Premium : IPreco
    {
        public double getCalculaPreco()
        {
            return 45.90;
        }
    }
}
