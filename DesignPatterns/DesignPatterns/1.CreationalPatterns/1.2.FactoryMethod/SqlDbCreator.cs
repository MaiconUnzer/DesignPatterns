namespace DesignPatterns._1.CreationalPatterns._1._2.FactoryMethod
{
    //Creator Concreto
    public class SqlDbCreator : DbCreator
    {
        //Factory Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerDbConnector(connectionString);
        }
    }
}
