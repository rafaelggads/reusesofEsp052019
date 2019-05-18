using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Method
{
    interface Factory
    {
        Veiculo createVeiculo(string condicao, int qtdPessoas);
    }
}
