using System;
using System.Text;
using Military_Elite.Interfaces;

namespace Military_Elite.Clases
{
    public class Spy:Soldier,ISpy
    {
        public Spy(string id, string firstName, string lastName,int codeNumber) :
            base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
            sb.Append($"Code Number: {CodeNumber}");
            return sb.ToString().TrimEnd();
            //Name: <firstName> <lastName> Id: <id>
            //Code Number: < codeNumber >
        }
    }
}