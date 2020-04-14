using System;

namespace DesignPatterns._2.StructuralPatterns._2._1.Adapter
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(Exception exception);
    }
}