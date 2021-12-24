using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers;
using CarRacing.Models.Racers.Contracts;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if (!racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return $"Race cannot be completed because both racers are not available!";
            }
            if (!racerTwo.IsAvailable())
            {
                return $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";
            }

            if (!racerOne.IsAvailable())
            {
                return $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";
            }
            racerOne.Race();
            racerTwo.Race();
            double racerOneBehaviarConst;
            if (racerOne.RacingBehavior == "strict")
            {
                racerOneBehaviarConst = 1.2;
            }
            else
            {
                racerOneBehaviarConst = 1.1;
            }
            double racerTwoBehaviarConst;
            if (racerOne.RacingBehavior == "strict")
            {
                racerTwoBehaviarConst = 1.2;
            }
            else
            {
                racerTwoBehaviarConst = 1.1;
            }

            var racerOneChanceToWin = racerOne.Car.HorsePower * racerOne.DrivingExperience * racerOneBehaviarConst;
            var racerTwoChanceToWin = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * racerTwoBehaviarConst;

            IRacer winner;
            if (racerOneChanceToWin > racerTwoChanceToWin)
            {
                winner = racerOne;
            }
            else
            {
                winner = racerTwo;
            }


            return $"{racerOne.Username} has just raced against {racerTwo.Username}! {winner.Username} is the winner!";


        }
    }
}