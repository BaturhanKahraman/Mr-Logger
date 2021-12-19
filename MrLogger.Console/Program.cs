using MrLogger.Loggers;
using System;

namespace MrLogger.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.Info("This is an info log");
            logger.Debug("This is an Debug log");
            logger.Error("This is an Error log");
            logger.Danger("This is an Danger log");
            logger = new FileLogger(@"D:\");
            logger.Debug("File logger çalışıyor.");
            logger.Info("File logger çalışıyor. Info");
            logger.Error("File logger çalışıyor. Error");
            logger.Danger("File logger çalışıyor. Danger");
            Console.ReadLine();
        }
    }
}
