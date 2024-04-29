using System;

namespace DesignPatterns._3.BehavioralPatterns._3._1.Command
{
    public class Main
    {
        public static void Executar()
        {
            var user = new Usuario();

            user.Adicionar('+', 100);
            Console.ReadKey();
            user.Adicionar('-', 100);
            Console.ReadKey();
            user.Adicionar('*', 100);
            Console.ReadKey();
            user.Adicionar('/', 100);
            Console.ReadKey();

            user.Desfazer(4);
            Console.ReadKey();

            user.Retornar(3);
        }
    }
}