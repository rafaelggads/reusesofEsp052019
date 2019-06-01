using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class UltraHd : IContentTransformer
    {
        public string converterQaulidade()
        {
            return "UltraHD";
        }
    }
}
