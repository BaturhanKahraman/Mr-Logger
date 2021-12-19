using System;
using System.IO;

namespace MrLogger.Utility.Helper
{
    internal static class FileHelper
    {
        /// <summary>
        /// Returns bool if the parameter is a directory
        /// </summary>
        /// <param name="path"></param>
        /// <returns>True if path is directory</returns>
        /// <exception cref="ArgumentNullException"></exception>
        internal static bool isDirectory(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));
            return File.GetAttributes(path).HasFlag(FileAttributes.Directory);
        }
        /// <summary>
        /// If sent parameter is a directory merges logfile and path.
        /// If directory doesn't exists, tries to create a directory.
        /// </summary>
        /// <param name="path">Sent full path into file logger</param>
        /// <param name="logFileName">log file name</param>
        /// <returns>Path if it is not directory, merges path and logfilename if it is directory.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        internal static string MergeDirectoryAndLogFile(string path, string logFileName = "log.txt")
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));
            if (string.IsNullOrEmpty(logFileName))
                throw new ArgumentNullException(nameof(logFileName));
            bool isDirectory = FileHelper.isDirectory(path);
            if (isDirectory)
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return Path.Combine(path, logFileName);
            }
            return path;
        }
    }
}
