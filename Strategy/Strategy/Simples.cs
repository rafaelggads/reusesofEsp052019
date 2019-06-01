using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Simples : IContentTransformer
    {
        public string converterQaulidade()
        {
            return "Simples";
        }
    }
}