using System;

namespace DesignPatterns._2.StructuralPatterns._2._3.Composite
{
    public class DomainMessage : IMessage
    {
        public string Texto { get; }

        public DomainMessage(string texto)
        {
            Texto = texto;
        }

        public void ExibirMensagens(int s)
        {
            Console.WriteLine(new string('-', s) + Texto);
        }
    }
}