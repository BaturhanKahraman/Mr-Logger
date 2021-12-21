using System;

namespace MrLogger.Utility.Extensions
{
    public static class Extensions
    {
        public static string AddDate(this string rawString) => DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " " + rawString;
        public static string AddLevel(this string rawString, string levelName) => levelName + " " + rawString;

        public static string GetWithDate(this string rawString, bool byDay)
        {
            if (!byDay)
                return rawString;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            return rawString + " " + date;s
        }
        
    }
}