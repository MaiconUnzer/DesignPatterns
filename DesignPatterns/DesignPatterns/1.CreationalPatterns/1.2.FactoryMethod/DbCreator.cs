using System;

namespace DesignPatterns._1.CreationalPatterns._1._2.FactoryMethod
{
    //Abstract Creator
    public abstract class DbCreator
    {
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbCreator Database(Database database)
        {
            switch (database)
            {
                case FactoryMethod.Database.SqlServer:
                    return new SqlDbCreator();
                case FactoryMethod.Database.Oracle:
                    return new OracleDbCreator();
                default:
                    throw new Exception("Não existe o database solicitado");
            }
        }
    }
}