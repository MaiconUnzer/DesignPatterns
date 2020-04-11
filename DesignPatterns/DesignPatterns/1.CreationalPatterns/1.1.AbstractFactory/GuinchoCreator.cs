using System;

namespace DesignPatterns._1.CreationalPatterns._1._1.AbstractFactory
{
    public class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno();
                case Porte.Medio:
                    return new GuinchoMedio();
                case Porte.Grande:
                    return new GuinchoGrande();
                default:
                    throw new Exception("Guincho não implementado para este porte");
            }
        }
    }
}
