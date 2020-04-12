namespace DesignPatterns._1.CreationalPatterns._1._2.FactoryMethod
{
    //Produto Concreto
    public class SqlServerDbConnector : DbConnector
    {
        public SqlServerDbConnector(string connectionString) : base(connectionString)
        {
        }

        public override Connection Connect()
        {
            //Retorna a connection para SqlServer
            return new Connection();
        }
    }
}
