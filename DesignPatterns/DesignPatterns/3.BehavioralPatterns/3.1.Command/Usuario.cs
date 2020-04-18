using System;
using System.Collections.Generic;

namespace DesignPatterns._3.BehavioralPatterns._3._1.Command
{
    /// <summary>
    /// 'Invoker' class
    /// </summary>
    public class Usuario
    {
        private readonly Calculadora _calculadora = new Calculadora();
        private List<Commander> _commands = new List<Commander>();
        private int _totalCommands;

        public void Adicionar(char operador, int valor)
        {
            Commander command = new CalculadoraCommand(_calculadora, operador, valor);
            command.Executar();

            _commands.Add(command);
            _totalCommands++;
        }

        public void Retornar(int niveis)
        {
            Console.WriteLine("\n----- Retornando {0} níveis ", niveis);

            for (int i = 0; i < niveis; i++)
            {
                if (_totalCommands >= _commands.Count - 1)
                    continue;

                var command = _commands[_totalCommands++];
                command.Executar();
            }
        }

        public void Desfazer(int niveis)
        {
            Console.WriteLine("\n----- Desfazendo {0} níveis ", niveis);

            for (int i = 0; i < niveis; i++)
            {
                if (_totalCommands <= 0)
                    continue;

                var command = _commands[--_totalCommands];
                command.Desfazer();
            }
        }
    }
}