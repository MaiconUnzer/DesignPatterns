using System;
using System.Collections.Generic;

namespace DesignPatterns._2.StructuralPatterns._2._3.Composite
{
    public class Mensagem : IMessage
    {
        private readonly List<IMessage> _childrenMessages = new List<IMessage>();

        public string Texto { get; }

        public Mensagem(string texto)
        {
            Texto = texto;
        }

        public void AdicionarMensagem(IMessage childMessage)
        {
            _childrenMessages.Add(childMessage);
        }

        public void RemoverMensagem(IMessage childMessage)
        {
            _childrenMessages.Remove(childMessage);
        }

        public void ExibirMensagens(int s)
        {
            Console.WriteLine(new string('-', s) + Texto);

            foreach (var child in _childrenMessages)
            {
                child.ExibirMensagens(s + 2);
            }
        }
    }
}