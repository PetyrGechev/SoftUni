namespace Raiding
{
    public abstract class BaseHero:IBaseHero
    {
        public BaseHero(string name, long power)
        {
            Name = name;
            Power = power;
        }
        public string Name { get; }
        public long Power { get; }
        public abstract string CastAbility();

    }
}