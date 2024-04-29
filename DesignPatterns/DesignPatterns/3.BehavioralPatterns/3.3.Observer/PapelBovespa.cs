namespace DesignPatterns._3.BehavioralPatterns._3._3.Observer
{
    //Concrete subject
    public class PapelBovespa : Investimento
    {
        public PapelBovespa(string simbolo, decimal preco) : base(simbolo, preco)
        { }
    }
}