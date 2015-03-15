namespace OfficeSoft.Logging
{
    public enum LogType
    {
        Information,
        Warning,
        Error,
    }
    public class LogModel
    {
        public string Message { get; set; }
        public string FunctionsName { get; set; }
        public LogType LogType { get; set; }


      
    }
}
