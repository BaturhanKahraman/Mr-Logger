using System;

namespace MrLogger.Utility.Extensions
{
    public static class StringExtension
    {
        public static string AddDate(this string rawString) => DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " " + rawString;
        public static string AddLevel(this string rawString, string levelName) => levelName + " " + rawString;
    }
}
