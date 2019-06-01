using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class DadosMeteorologicos : Subject
    {
        private IList<Observer> observers;
        private float _temperatura;
        private float _umidade;
        private float _pressao;

        public DadosMeteorologicos()
        {
            observers = new List<Observer>();
        }

        public void registerObserver(Observer observer) 
        {
            observers.Add(observer);
        }

        public void unregisterObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers() 
        {
            for (int i = 1; i < observers.Count(); i++) {
                Observer observer = (Observer) observers.ElementAt(i);
                observer.update(_temperatura, _umidade, _pressao);
            }
        }

        public void notificaLeitura () 
        {
            notifyObservers();
        }

        public void realizaLeitura (float temperatura, float umidade, float pressao) 
        {
            this._temperatura = temperatura;
            this._umidade = umidade;
            this._pressao = pressao;
            notificaLeitura();
        }
    }
}
