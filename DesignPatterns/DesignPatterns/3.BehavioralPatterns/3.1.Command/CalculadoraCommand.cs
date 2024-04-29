using System;

namespace DesignPatterns._3.BehavioralPatterns._3._1.Command
{
    /// <summary>
    /// 'ConcreteCommand' class
    /// </summary>
    public class CalculadoraCommand : Commander
    {
        private readonly char _operador;
        private readonly int _valor;
        private readonly Calculadora _calculadora;

        public CalculadoraCommand(Calculadora calculadora, char operador, int valor)
        {
            _calculadora = calculadora;
            _operador = operador;
            _valor = valor;
        }

        public override void Desfazer()
        {
            _calculadora.Operacao(Desfazer(_operador), _valor);
        }

        public override void Executar()
        {
            _calculadora.Operacao(_operador, _valor);
        }

        private char Desfazer(char operador)
        {
            switch (operador)
            {
                case '+':
                    return '-';
                case '-':
                    return '+';
                case '*':
                    return '/';
                case '/':
                    return '*';
                default:
                    throw new Exception("Operador desconhecido");
            }
        }
    }
}