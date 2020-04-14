using System;

namespace DesignPatterns._2.StructuralPatterns._2._1.Adapter
{
    // Adapter Class
    public class LogAdapter : ILogger
    {
        private readonly ILogNetMaster _logNetMaster;

        public LogAdapter(ILogNetMaster logNetMaster)
        {
            _logNetMaster = logNetMaster;
        }

        public void Log(string message)
        {
            _logNetMaster.LogInfo(message);
        }

        public void LogError(Exception exception)
        {
            _logNetMaster.LogException(exception);
        }
    }
}