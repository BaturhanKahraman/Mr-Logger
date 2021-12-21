using System.IO;
using System;
using MrLogger.Utility.Extensions;
using MrLogger.Utility.Helper;
using MrLogger.Settings;

namespace MrLogger.Loggers
{
    public class FileLogger :ConsoleLogger, IFileLogger
    {
        private string _fullPath;
        private readonly FileSetting _fileSetting;
        /// <summary>
        /// Default ctor. It will get current directory as default.
        /// </summary>
        public FileLogger()
        {
            _fullPath = FileHelper.MergeDirectoryAndLogFile(Directory.GetCurrentDirectory(),"log.txt");
        }
        /// <summary>
        /// Ctor with full path.
        /// </summary>
        /// <param name="fullPath">Your full path. You can both give file name or not. Default is log.txt</param>
        public FileLogger(string fullPath)
        {
            _fullPath = FileHelper.MergeDirectoryAndLogFile(fullPath, "log.txt");
        }

        public FileLogger(FileSetting fileSetting) 
        {
            _fileSetting = fileSetting ?? throw new ArgumentNullException(nameof(fileSetting));
        }

        public FileLogger(bool readSettingsFromSettings)
        {
            //TODO
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

        public void SetUpFileSetting()
        {
            //TODO
            //DÜZELTİLECEK.
            _fullPath= FileHelper.MergeDirectoryAndLogFile(_fileSetting.FullPath);
            if (_fileSetting.LogFilePerDay)
            {
                //TODO
                //CHECK if there is a file for today
                //If no file Create it
                string fullPathWithDate = _fileSetting.FullPath.GetWithDate(_fileSetting.DateTimeInFileName);
                if (!File.Exists(fullPathWithDate))
                {
                    File.Create(fullPathWithDate).Close();
                }


            }
        }
    }
}
