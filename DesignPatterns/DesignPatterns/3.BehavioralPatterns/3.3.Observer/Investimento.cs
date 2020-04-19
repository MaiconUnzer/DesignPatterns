using System;
using System.Collections.Generic;

namespace DesignPatterns._3.BehavioralPatterns._3._3.Observer
{
    //Abstract Subject
    public abstract class Investimento
    {
        private decimal _valor;
        private readonly List<IObservador> _observadores = new List<IObservador>();

        public string Simbolo { get; }

        public decimal Valor
        {
            get => _valor;
            set
            {
                if (_valor == value) return;

                _valor = value;
                Notificar();
            }
        }

        protected Investimento(string simbolo, decimal valor)
        {
            Simbolo = simbolo;
            _valor = valor;
        }

        public void Subscribe(IObservador observador)
        {
            _observadores.Add(observador);
            Console.WriteLine("Notificando que {0} está recebendo atualizações de {1}", observador.Nome, Simbolo);
        }

        public void Usubscribe(IObservador observador)
        {
            _observadores.Remove(observador);
            Console.WriteLine("Notificando que {0} NÃO está recebendo atualizações de {1}", observador.Nome, Simbolo);
        }

        private void Notificar()
        {
            foreach (var observador in _observadores)
            {
                observador.Notificar(this);
            }
        }

    }
}
