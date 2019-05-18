using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Method
{
    class FactoryCrise : Factory
    {
        public Veiculo createVeiculo(string condicao, int qtdPessoas)
        {
            return new Tesla();
        }
    }
}
