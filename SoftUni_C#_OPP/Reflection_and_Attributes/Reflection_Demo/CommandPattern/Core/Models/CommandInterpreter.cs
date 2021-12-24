using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args) //hello cunt
        {
            string result = "";
           
                string[] inputInfo = args.Split();
                string command = inputInfo[0] + "Command";
                string[] input = inputInfo[1..];

                Type type = Assembly.GetCallingAssembly().GetTypes().Where(t => t.Name == command).FirstOrDefault();
                if (type==null)
                {
                    throw new InvalidOperationException("Invalid operation ");
                }

                ICommand theCommand = (ICommand)Activator.CreateInstance(type);
                 result = theCommand.Execute(input);
                return result;


            
        }

    }
}
