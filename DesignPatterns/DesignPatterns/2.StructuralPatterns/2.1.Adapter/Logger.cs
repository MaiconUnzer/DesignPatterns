using System;

namespace DesignPatterns._2.StructuralPatterns._2._1.Adapter
{
    //Target class
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log Padrão => ", message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("LogError Padrão => ", exception.Message);
        }
    }
}