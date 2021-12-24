namespace Easter.Models.Bunnies.Contracts
{
    public class SleepyBunny:Bunny
    {
        public SleepyBunny(string name) : base(name, 50)
        {
        }
        public override void Work()
        {
            if (energy - 15 < 0)
            {
                energy = 0;
            }
            else
            {
                energy -= 15;
            }
        }
    }
}