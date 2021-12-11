using System;
using Gym.Utilities.Messages;

namespace Gym.Models.Athletes
{
    public class Boxer:Athlete
    {
        public Boxer(string fullName, string motivation, int numberOfMedals) 
            : base(fullName, motivation, numberOfMedals, 60)
        {
        }

        public override void Exercise()
        {
            if (Stamina+15>100)
            {
                Stamina = 100;
                throw new ArgumentException(ExceptionMessages.InvalidStamina);
            }
            else
            {
                Stamina += 15;
            }
        }
    }
}