using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roaster = new List<Player>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        private List<Player> roaster;
        //Method AddPlayer(Player player) - adds an entity to the roster if there is room for it
        public void AddPlayer(Player player)
        {
            if (roaster.Count < Capacity && !roaster.Any(x => x.Name == player.Name))
            {
                roaster.Add(player);
            }
        }
        //Method RemovePlayer(string name) - removes a player by given name, if such exists, and returns bool
        public bool RemovePlayer(string name)
        {
            var isPlayerIn = roaster.Any(x => x.Name == name);
            if (isPlayerIn)
            {
                var player = roaster.FirstOrDefault(x => x.Name == name);
                roaster.Remove(player);
                return true;
            }

            return false;
        }
        //Method PromotePlayer(string name) - promote(set his rank to "Member") the first player with the given name.If the player is already a "Member", do nothing.
        public void PromotePlayer(string name)
        {
          
            if (roaster.Any(x => x.Name == name))
            {
                Player myPromotedPlayer = roaster.Where(x => x.Name == name).FirstOrDefault();
                myPromotedPlayer.Rank = "Member";
            }


        }
        //Method DemotePlayer(string name)- demote(set his rank to "Trial") the first player with the given name.If the player is already a "Trial",  do nothing.
        public void DemotePlayer(string name)
        {
            if (roaster.Any(x => x.Name == name))
            {
                Player myDemotedPlayer = roaster.Where(x => x.Name == name).FirstOrDefault();
                myDemotedPlayer.Rank = "Trial";
            }


        }
        //Method KickPlayersByClass(string class) - removes all the players by the given class and returns all players from that class as an array
        public Player[] KickPlayersByClass(string @class)
        {
            var players = roaster.Where(x => x.Class == @class).ToArray();
            roaster.RemoveAll(x => x.Class == @class);
            return players;
        }
        //Getter Count - returns the number of players
        public int Count => roaster.Count;
        //Report() - returns a string in the following format:	
        public string Report()
        {

            //"Players in the guild: {guildName}
            //{ Player1}
            //{ Player2}
            //(…)
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in roaster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
