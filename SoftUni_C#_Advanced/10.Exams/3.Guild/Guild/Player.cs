using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public Player(string name,string @class)
        {
            Class = @class;
            Name = name;
            Rank = "Trial";
            Description = "n/a";
        }
        public string Name { get; set; }

        public string Class { get; set; }

        public string Rank { get; set; }

        public string Description { get; set; }
        //Name: string
        //Class: string
        //Rank: string – "Trial" by default
        //Description: string – "n/a" by default
    //    "Player {Name}: {Class}
    //    Rank: {Rank}
    //    Description: {Description}
    //"
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {Name}: {Class}");
            sb.AppendLine($"Rank: {Rank}");
            sb.Append($"Description: {Description}");
            return sb.ToString().TrimEnd();
        }
    }
}
