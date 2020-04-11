namespace DesignPatterns._1.CreationalPatterns._1._1.AbstractFactory
{
    //AbstractProduct
    public abstract class Guincho
    {
        public Porte Porte { get; private set; }

        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
    }

    //Produto Concreto
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno() : base(Porte.Pequeno)
        { }

        public override void Socorrer(Veiculo veiculo)
        {
            //Faz alguma coisa
        }
    }

    //Produto Concreto
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio() : base(Porte.Medio)
        { }

        public override void Socorrer(Veiculo veiculo)
        {
            //Faz alguma coisa
        }
    }

    //Produto Concreto
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande() : base(Porte.Grande)
        { }

        public override void Socorrer(Veiculo veiculo)
        {
            //Faz alguma coisa
        }
    }
}
