using Solid.enumerator;

namespace Solid.Interfaces
{
    public interface IAppender
    {
       
        public ILayout Layout { get;  }
        public ReportLevel ReportLevel { get; set; }
        public void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}