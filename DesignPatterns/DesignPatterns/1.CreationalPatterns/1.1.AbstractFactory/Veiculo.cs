namespace DesignPatterns._1.CreationalPatterns._1._1.AbstractFactory
{
    //AbstractProduct
    public abstract class Veiculo
    {
        public string Modelo { get; private set; }
        public Porte Porte { get; private set; }

        protected Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = Porte;
        }
    }

    //Produto Concreto
    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo) : base(modelo, Porte.Pequeno)
        { }
    }

    //Produto Concreto
    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string modelo) : base(modelo, Porte.Medio)
        { }
    }

    //Produto Concreto
    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string modelo) : base(modelo, Porte.Grande)
        { }
    }
}
