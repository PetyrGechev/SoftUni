using Military_Elite.Interfaces;

namespace Military_Elite.Clases
{
    public abstract class SpecialisedSoldier:Private,ISpecialisedSoldier
    {
        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; set; }
    }
}