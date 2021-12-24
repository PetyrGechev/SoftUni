namespace Raiding
{
    
        public class Warrior : BaseHero
        {
            private const int WarirorPower = 100;
            public Warrior(string name) : base(name, WarirorPower)
            {

            }


            public override string CastAbility() => $"{this.GetType().Name} - {Name} hit for {WarirorPower} damage";
        }
    }
