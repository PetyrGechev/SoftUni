using System;
using System.Dynamic;
using System.Linq;
using System.Text;
using Solid.Interfaces;

namespace Solid.Classes
{
    public class LogFile :ILogFile
    {
        private StringBuilder stringBuilder;

        public LogFile()
        {
            stringBuilder = new StringBuilder();
        }


        public int Size => stringBuilder.ToString().Where(c => char.IsLetter(c)).Sum(c => c);

        public void Write(string message)
        {
            stringBuilder.Append(message + Environment.NewLine);
        }
    }
}