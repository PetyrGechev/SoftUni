using System;
using System.Collections.Generic;
using System.Text;
using Solid.enumerator;
using Solid.Interfaces;

namespace Solid.Classes
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;
        }
        public ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (ReportLevel<=reportLevel)
            {
                Console.WriteLine(string.Format(this.Layout.Format, dateTime, reportLevel, message));
            }
            
        }

       
    }
}
