using System;
using System.Collections.Generic;
using System.Text;

namespace MrLogger.Utility.Exceptions
{
    public class EmptyPathException : SystemException
    {
        public EmptyPathException(string path) : base(path + " path string is null or empty.")
        {
        }
    }
}
