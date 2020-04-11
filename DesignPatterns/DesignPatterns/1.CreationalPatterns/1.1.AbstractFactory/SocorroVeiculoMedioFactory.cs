namespace DesignPatterns._1.CreationalPatterns._1._1.AbstractFactory
{
    public class SocorroVeiculoMedioFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Medio);
        }

        public override Veiculo CriarVeiculo(string modelo)
        {
            return VeiculoCreator.Criar(modelo, Porte.Medio);
        }
    }
}
