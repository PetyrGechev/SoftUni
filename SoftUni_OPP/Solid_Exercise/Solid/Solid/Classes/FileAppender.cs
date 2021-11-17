using System;
using System.IO;
using Solid.enumerator;
using Solid.Interfaces;

namespace Solid.Classes
{
    public class FileAppender:IAppender
    {
        private const string FilePath = "result.txt";
        public FileAppender(ILayout layout,ILogFile file)
        {
            Layout = layout;
            LogFile = file;
        }
        public ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }
        public ILogFile LogFile { get; set; }
        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (ReportLevel<=reportLevel)
            {
                string info = string.Format(this.Layout.Format, dateTime, reportLevel, message);
                File.AppendAllText(FilePath, info + Environment.NewLine);
            }
            
        }
    }
}