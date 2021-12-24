using System.Linq;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;
using Easter.Repositories;

namespace Easter.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        private EggRepository eggs;
        private BunnyRepository bunnies;
        public Workshop()
        {
            eggs = new EggRepository();
            bunnies = new BunnyRepository();
        }
        public void Color(IEgg egg, IBunny bunny)
        {

            
            while (bunny.Energy > 0 &&!egg.IsDone())
            {
                IDye dye = bunny.Dyes.FirstOrDefault();
                if (dye==null)
                {
                    break;
                }
                if (dye.IsFinished())
                {
                    bunny.Dyes.Remove(dye);
                    continue;
                }

                
                bunny.Work();
                dye.Use();
                egg.GetColored();
            }
            

        }
    }
}