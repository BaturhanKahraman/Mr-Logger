using System;
using System.Collections.Generic;
using System.Text;

namespace MrLogger.Settings
{
    public class DatabaseSetting:Setting
    {
        public string ConnectionString { get; set; }
        public string TableName { get; set; } = "Log";
        public bool CreateTable { get; set; } = false;
    }
}
