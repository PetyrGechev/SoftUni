using Solid.Interfaces;

using Solid.enumerator;
namespace Solid.Classes
{
    public class Logger:ILogger
    {
        public Logger(IAppender appender)
        {
            Appender = appender;
        }
        public IAppender Appender { get; }
        public void Info(string dateTime, string message)
        {
            Appender.Append(dateTime,ReportLevel.Info,message);
        }

        public void Warning(string dateTime, string message)
        {
            Appender.Append(dateTime, ReportLevel.Warning, message);
        }

        public void Error(string dateTime, string message)
        {
            Appender.Append(dateTime, ReportLevel.Error, message);
        }

        public void Critical(string dateTime, string message)
        {
            Appender.Append(dateTime, ReportLevel.Critical, message);
        }

        public void Fatal(string dateTime, string message)
        {
            Appender.Append(dateTime, ReportLevel.Fatal, message);
        }
    }
}