using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer.Solucao_Professor;
namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Coleta Temperatura \n");
            float temperatura = float.Parse(Console.ReadLine());
            Console.Write("Coleta Umidade \n");
            float umidade = float.Parse(Console.ReadLine());
            Console.Write("Coleta Pressao \n");
            float pressao = float.Parse(Console.ReadLine());*/

            /*
             * Minha Solução
             * 
            DadosMeteorologicos dadosMeteorlogicos = new DadosMeteorologicos();

            NotificacaoDadosMeteorologicos empresa1 = new NotificacaoDadosMeteorologicos(dadosMeteorlogicos);
            NotificacaoDadosMeteorologicos empresa2 = new NotificacaoDadosMeteorologicos(dadosMeteorlogicos);
            NotificacaoDadosMeteorologicos empresa3 = new NotificacaoDadosMeteorologicos(dadosMeteorlogicos);

            dadosMeteorlogicos.registerObserver(empresa1);

            dadosMeteorlogicos.realizaLeitura(temperatura, umidade, pressao);*/

            Estacao estacao = new Estacao();
            Interessado interessado = new ClimaTempo(estacao);
            Interessado inmet = new Inmet(estacao);

            estacao.register(interessado);
            estacao.setTemperatura(10);
            Console.ReadKey();
        }
    }
}
