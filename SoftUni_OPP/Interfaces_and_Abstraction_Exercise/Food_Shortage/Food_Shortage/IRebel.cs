namespace Food_Shortage
{
    public interface IRebel:IBuyer,IAge
    {
        public string Name { get;  }
        public string Group { get; }
    }
}