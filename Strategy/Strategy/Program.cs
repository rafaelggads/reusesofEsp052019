using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Básico
            IPreco preco = new Basico();
            IContentTransformer qualidade = new Simples();
            IPreparadorNumeroTransmissoes numeroLimite = new TransmissaoUnica();

            Assinatura plano = new Assinatura(preco, qualidade, numeroLimite);

            Console.WriteLine(plano.getPreco());
            Console.WriteLine(plano.disponibilizarConteudo());
            plano.permitirNumeroTransmissoesSimultaneas();
            Console.ReadKey();
        }
    }
}
