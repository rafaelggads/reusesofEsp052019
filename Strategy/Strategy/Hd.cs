using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Hd : IContentTransformer
    {
        public string converterQaulidade()
        {
            return "HD";
        }
    }
}
