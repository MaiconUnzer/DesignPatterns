using System;

namespace DesignPatterns._1.CreationalPatterns._1._1.AbstractFactory
{
    public class SocorroVeiculoPequenoFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Pequeno);
        }

        public override Veiculo CriarVeiculo(string modelo)
        {
            return VeiculoCreator.Criar(modelo, Porte.Pequeno);
        }
    }
}
