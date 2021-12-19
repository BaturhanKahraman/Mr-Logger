using System;
using System.Collections.Generic;
using System.Text;

namespace MrLogger.Loggers
{
    public class DatabaseLogger : IDatabaseLogger, IDisposable
    {

        public DatabaseLogger()
        {

        }
        public void Danger(string message)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, Exception exp)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }
    }
}
