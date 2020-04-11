namespace DesignPatterns._1.CreationalPatterns._1._1.AbstractFactory
{
    class SocorroVeiculoGrandeFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Grande);
        }

        public override Veiculo CriarVeiculo(string modelo)
        {
            return VeiculoCreator.Criar(modelo, Porte.Grande);
        }
    }
}
