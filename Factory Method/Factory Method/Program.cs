using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Definindo qual o tipo de veiculo ***");

            Console.WriteLine("Qual distância a ser percorrida ?");
            int distancia = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Qual a condição metereológica {Sol, Chuva} ?");
            string condicaoMetereologica = Console.ReadLine();

            Console.WriteLine("Quantidade de Pessoas ?");
            int qtdPessoas = Convert.ToInt16(Console.ReadLine());

            try
            {
                if (distancia <= 500)
                {
                    FactoryConcret factory = new FactoryConcret();
                    Console.WriteLine(factory.createVeiculo(condicaoMetereologica, qtdPessoas).getDescricao());
                }
                else
                {
                    Console.WriteLine("Não foi possível definir um veículo");
                }
            } 
            catch(Exception e)
            {
                Console.WriteLine("Não foi possível definir um veiculo");
            }

            Console.ReadKey(); 
        }

        private void definirVeiculo()
        { 
        }
    }
}
