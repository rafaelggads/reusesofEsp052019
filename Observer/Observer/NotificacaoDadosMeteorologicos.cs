using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class NotificacaoDadosMeteorologicos : Observer, Notificacao
    {
        private float _temperatura;
        private float _umidade;
        private float _pressao;

        public NotificacaoDadosMeteorologicos (Subject dadosMeteorologico) 
        {
            dadosMeteorologico.registerObserver(this);
        }
   
        public void update(float temperatura, float umidade, float pressao) 
        {
            this._temperatura = temperatura;
            this._umidade = umidade;
            this._pressao = pressao;

            show();
        }

        public void show() 
        {
            Console.WriteLine( "Condições atuais: temperatura " + _temperatura  + "F, umidade : " + _umidade + "%, pressao: ");
        }


    }
}
