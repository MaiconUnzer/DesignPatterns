namespace DesignPatterns._1.CreationalPatterns._1._2.FactoryMethod
{
    //Abstract Product
    public abstract class DbConnector
    {
        protected string ConnectionString { get; set; }

        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public abstract Connection Connect();
    }
}
