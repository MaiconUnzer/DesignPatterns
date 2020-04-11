namespace DesignPatterns._1.CreationalPatterns._1._1.AbstractFactory
{
    //Abstract Factory
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();

        public abstract Veiculo CriarVeiculo(string modelo);
    }
}
