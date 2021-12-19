using MrLogger.Utility.Helper;
using System;

namespace MrLogger.Loggers
{
    public class ConsoleLogger :IConsoleLogger
    {
        public virtual void Danger(string message)
        {
            ConsoleHelper.ConsoleWriteWithColorLevel(message, ConsoleColor.Yellow, nameof(this.Danger));
        }

        public virtual void Debug(string message)
        {
            ConsoleHelper.ConsoleWriteWithColorLevel(message, ConsoleColor.DarkYellow, nameof(this.Debug));
        }

        public virtual void Error(string message)
        {
            ConsoleHelper.ConsoleWriteWithColorLevel(message, ConsoleColor.Red, nameof(this.Error));

        }

        public virtual void Error(string message, Exception exp)
        {
            ConsoleHelper.ConsoleWriteWithColorLevel(message + Environment.NewLine + exp, ConsoleColor.Red, nameof(this.Error));
        }

        public virtual void Info(string message)
        {
            ConsoleHelper.ConsoleWriteWithColorLevel(message, ConsoleColor.Green, nameof(this.Info));
        }
    }
}
