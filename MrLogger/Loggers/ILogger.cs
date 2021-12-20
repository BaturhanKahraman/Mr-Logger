using System;

namespace MrLogger.Loggers
{
    public interface ILogger
    {
        void Info(string message);
        void Danger(string message);
        void Error(string message);
        void Error(string message, Exception exp);
        void Debug(string message);
    }
}
