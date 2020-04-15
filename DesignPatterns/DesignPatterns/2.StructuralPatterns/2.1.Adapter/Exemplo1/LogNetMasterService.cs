using System;

namespace DesignPatterns._2.StructuralPatterns._2._1.Adapter
{
    //Adaptee class - Classe utilizada para substituir a classe Target (Logger)
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogException(Exception exception)
        {
            Console.WriteLine("LogException Customizado => ", exception.Message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("Log Customizado => ", message);
        }
    }
}