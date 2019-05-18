using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Method
{
    class FactoryConcret : Factory
    {
        public Veiculo createVeiculo(string condicao, int qtdPessoas)
        { 
            if (qtdPessoas <= 2) 
            {
                return new Tesla();
            } 
            else if (qtdPessoas <= 5 && condicao.Equals("Sol"))
            {
                return new Escort();
            }
            else if (qtdPessoas <= 5 && condicao.Equals("Chuva"))
            {
                return new Opala();
            }
            else if (qtdPessoas > 5 && qtdPessoas <= 20)
            {
                return new Besta();
            }

            return null;
        }
    }
}
