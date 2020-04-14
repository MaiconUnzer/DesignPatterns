using System;

namespace DesignPatterns._2.StructuralPatterns._2._1.Adapter
{
    public interface ILogNetMaster
    {
        void LogInfo(string message);
        void LogException(Exception exception);
    }
}
