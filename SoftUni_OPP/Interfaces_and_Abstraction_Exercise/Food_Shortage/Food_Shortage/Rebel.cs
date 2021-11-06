namespace Food_Shortage
{
    public class Rebel:IRebel
    {
        public Rebel(string name, string age, string group)
        {
            Age = age;
            Group = group;
            Name = name;
        }


        public int Food { get; private set; }
        
        public string Name { get; private set; }
        public string Group { get; private set; }

        public void BuyFood()
        {
            Food += 5;
        }

        public string Age { get; private set; }
    }
}