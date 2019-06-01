using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Solucao_Professor
{
    class Estacao : IEstacao
    {
        private double _temperatura;
        private double _pressao;
        private double _umidade;

        private IList<Interessado> observers;

        public Estacao()
        {
            observers = new List<Interessado>();
        }

        public double getTemperatura()
        {
            return _temperatura;
        }

        public void setTemperatura(double temperatura)
        {
            this._temperatura = temperatura;
            notificar();
        }

        public double getPressao()
        {
            return _pressao;
        }

        public void setPressao(double pressao)
        {
            this._pressao = pressao;
            notificar();
        }

        public double getUmidade()
        {
            return _umidade;
        }

        public void setUmidade(double umidade)
        {
            this._umidade = umidade;
            notificar();
        }

        public void register(Interessado interessado) 
        {
            observers.Add(interessado);
               
        }

        public void unregister(Interessado interessado)
        {
            observers.Remove(interessado);
        }

        public void notificar() 
        {
            for (int i = 1; i < observers.Count(); i++)
            {
                Interessado observer = (Interessado)observers.ElementAt(i);
                observer.atualizar();
            }
        }
    }
}
