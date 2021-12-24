using System.Collections.Generic;

namespace Solid.Interfaces
{
    public interface ILogger
    {
        //Info > Warning > Error > Critical > Fatal
        public List<IAppender> Appenders { get; }
        
        public void Info(string dateTime, string message);
        public void Warning(string dateTime, string message);
        public void Error(string dateTime, string message);
        public void Critical(string dateTime, string message);
        public void Fatal(string dateTime, string message);


    }
}