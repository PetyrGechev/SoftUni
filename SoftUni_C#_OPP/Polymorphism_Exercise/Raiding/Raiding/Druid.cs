using System;

namespace Raiding
{
    public class Druid:BaseHero
    {
        
        private const long druidPower = 80;

        public Druid(string name) 
            : base(name, druidPower)
        {
            
        }

        public override string CastAbility() => $"{this.GetType().Name} - {Name} healed for {druidPower}";

        // Druid - Josh healed for 80



    }
}