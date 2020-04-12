namespace DesignPatterns._1.CreationalPatterns._1._2.FactoryMethod
{
    public class Main
    {
        public static void Executar()
        {
            var sqlConnection = DbCreator.Database(Database.SqlServer) // Retorna um Creator Concreto
                                            .CreateConnector("minha connectionString") //Factory Method que retorna um produto concreto
                                            .Connect();

            
            var oracleConnection = DbCreator.Database(Database.Oracle) // Retorna um Creator Concreto
                                            .CreateConnector("minha connectionString") //Factory Method que retorna um produto concreto
                                            .Connect();
        }
    }
}
