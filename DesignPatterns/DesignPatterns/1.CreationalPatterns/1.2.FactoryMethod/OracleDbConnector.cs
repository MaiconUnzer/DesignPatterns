namespace DesignPatterns._1.CreationalPatterns._1._2.FactoryMethod
{
    //Produto Concreto
    public class OracleDbConnector : DbConnector
    {
        public OracleDbConnector(string connectionString) : base(connectionString)
        {
        }

        public override Connection Connect()
        {
            //Retorna a connection para Oracle
            return new Connection();
        }
    }
}
