using System;

namespace DesignPatterns._3.BehavioralPatterns._3._1.Command
{
    /// <summary>
    /// 'Receiver' class
    /// </summary>
    public class Calculadora
    {
        private int _valorAtual;

        public void Operacao(char operador, int valor)
        {
            switch (operador)
            {
                case '+':
                    _valorAtual += valor;
                    break;
                case '-':
                    _valorAtual -= valor;
                    break;
                case '*':
                    _valorAtual *= valor;
                    break;
                case '/':
                    _valorAtual /= valor;
                    break;
            }

            Console.WriteLine("(dado {0} {1}) => Valor atual = {2,3}", operador, valor, _valorAtual);
        }
    }
}