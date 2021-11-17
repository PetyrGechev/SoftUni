using System.Collections.Generic;
using System.Xml;
using Solid.Interfaces;

using Solid.enumerator;
namespace Solid.Classes
{
    public class Logger : ILogger
    {
       
        public Logger(params IAppender[] appenders)
        {
            Appenders = new List<IAppender>();
            foreach (var appender in appenders)
            {
                
               this.Appenders.Add(appender);
            }
        }

        public List<IAppender> Appenders { get; }

        public void Info(string dateTime, string message)
        {
            AppendInAll(dateTime,ReportLevel.Info ,message);
        }

        private void AppendInAll(string dateTime,ReportLevel reportLevel ,string message)
        {
            foreach (var appender in Appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public void Warning(string dateTime, string message)
        {
            AppendInAll(dateTime, ReportLevel.Warning, message); ;
        }

        public void Error(string dateTime, string message)
        {
            AppendInAll(dateTime, ReportLevel.Error, message); ;
        }

        public void Critical(string dateTime, string message)
        {
            AppendInAll(dateTime, ReportLevel.Critical, message);
        }

        public void Fatal(string dateTime, string message)
        {
            AppendInAll(dateTime, ReportLevel.Fatal, message);
        }
    }
}