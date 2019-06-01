using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Solucao_Professor
{
    class ClimaTempo : Interessado
    {
        private Estacao estacao;

        public ClimaTempo (Estacao estacao)
        {
            this.estacao = estacao;
        }

        public void atualizar()
        {
            Console.WriteLine("Temperatura " + estacao.getTemperatura());
            Console.WriteLine("Presao " + estacao.getPressao());
            Console.WriteLine("Umidade " + estacao.getUmidade());
        }

        
    }
}
