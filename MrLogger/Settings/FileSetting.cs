namespace MrLogger.Settings
{
    public class FileSetting : Setting
    {
        public string FullPath { get; set; }
        public long FileSizeLimit { get; set; }
        public bool DateTimeInFileName { get; set; }
        public bool LogFilePerDay { get; set; }
    }
}
