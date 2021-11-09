using System.Globalization;

namespace Raiding
{
    public interface IBaseHero
    {
        //BaseHero – string Name, int Power, string CastAbility()
        public string Name { get; }
        public long Power { get; }
        public string CastAbility();
    }
}