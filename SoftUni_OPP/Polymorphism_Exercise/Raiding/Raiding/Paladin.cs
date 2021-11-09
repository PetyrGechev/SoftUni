namespace Raiding
{
    public class Paladin:BaseHero
    {
        private const long PaladinPower = 100;
        public Paladin(string name ) : base(name, PaladinPower)
        {

        }

 
        public override string CastAbility() => $"{this.GetType().Name} - {Name} healed for {PaladinPower}";
    }
}