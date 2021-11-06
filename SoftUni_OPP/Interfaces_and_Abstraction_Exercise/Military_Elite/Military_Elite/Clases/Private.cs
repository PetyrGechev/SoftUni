using Military_Elite.Interfaces;

namespace Military_Elite.Clases
{
    public class Private:Soldier,IPrivate
    {
        public Private(string id, string firstName, string lastName,decimal salary)
            : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public decimal Salary { get; }
        public override string ToString()
        {
        
        //Name: < firstName > < lastName > Id: < id > Salary: < salary >
        //Name: Peter Johnson Id: 1 Salary: 22.22
        return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}";
        }
    }
}