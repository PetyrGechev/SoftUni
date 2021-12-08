using Easter.Models.Dyes.Contracts;

namespace Easter.Models.Dyes
{
    public class Dye : IDye
    {
        private int power;
        public Dye(int power)
        {
            Power = power;
        }

        public int Power
        {
            get => power;
            private set
            {
                if (value < 0)
                {
                    value = 0;
                }

                power = value;
            }

        }
        public void Use()
        {
            if (power - 10 < 0)
            {
                power = 0;
            }
            else
            {
                power -= 10;
            }
        }

        public bool IsFinished()
        {
            return power == 0;   
        }
    }
}