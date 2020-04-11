using System;

namespace DesignPatterns._1.CreationalPatterns._1._1.AbstractFactory
{
    public class VeiculoCreator
    {
        public static Veiculo Criar(string modelo, Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new VeiculoPequeno(modelo);
                case Porte.Medio:
                    return new VeiculoMedio(modelo);
                case Porte.Grande:
                    return new VeiculoGrande(modelo);
                default:
                    throw new Exception("Veiculo desde porte não implementado");
            }
        }
    }
}
