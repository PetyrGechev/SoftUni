namespace Raiding
{
    public class Rogue : BaseHero
    {
        private const long RoguePower = 80;
        public Rogue(string name) : base(name, RoguePower)
        {

        }


        public override string CastAbility() => $"{this.GetType().Name} - {Name} hit for {RoguePower} damage";
    }
}