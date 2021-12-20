using MrLogger.Utility.Extensions;
using System;

namespace MrLogger.Utility.Helper
{
    internal class ConsoleHelper
    {
        internal static void ConsoleWriteWithColorLevel(string message, ConsoleColor consoleColor, string level)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(message.AddDate().AddLevel(level));
        }
    }
}
