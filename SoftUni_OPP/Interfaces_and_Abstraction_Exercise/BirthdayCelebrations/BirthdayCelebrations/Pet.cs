namespace BirthdayCelebrations
{
    public class Pet :IPet
    {
        public Pet(string name, string birthday)
        {
            Birthday = birthday;
            Name = name;
        }

        public string Birthday { get; private set; }
        public string Name { get; private set; }
    }
}