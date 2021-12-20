using System.IO;
using System;
using MrLogger.Utility.Extensions;
using MrLogger.Utility.Helper;

namespace MrLogger.Loggers
{
    public class FileLogger :ConsoleLogger, IFileLogger,IDisposable
    {
        private readonly string _fullPath;
        //private readonly FileStream _stream;
        public FileLogger(string fullPath)
        {
            fullPath ??= Directory.GetCurrentDirectory();
            //_stream = new FileStream(fullPath, FileMode.OpenOrCreate);
            _fullPath = FileHelper.MergeDirectoryAndLogFile(fullPath, "log.txt");
        }

        public override void Danger(string message)
        {
            File.AppendAllText(_fullPath, message.AddDate().AddLevel(nameof(this.Danger)) + Environment.NewLine);
            base.Danger(message);
        }

        public override void Debug(string message)
        {
            File.AppendAllText(_fullPath, message.AddDate().AddLevel(nameof(this.Debug)) + Environment.NewLine);
            base.Debug(message);
        }

        public override void Error(string message)
        {
            File.AppendAllText(_fullPath, message.AddDate().AddLevel(nameof(this.Error)) + Environment.NewLine);
            base.Error(message);
        }

        public override void Error(string message, Exception exp)
        {
            File.AppendAllText(_fullPath, message.AddDate().AddLevel(nameof(this.Error)) + Environment.NewLine + exp + Environment.NewLine);
            base.Error(message,exp);
        }

        public override void Info(string message)
        {
            File.AppendAllText(_fullPath, message.AddDate().AddLevel(nameof(this.Info)) + Environment.NewLine);
            base.Info(message);
        }
        public void Dispose()
        {
            //_stream.Close();
            //throw new NotImplementedException();
        }
    }
}
