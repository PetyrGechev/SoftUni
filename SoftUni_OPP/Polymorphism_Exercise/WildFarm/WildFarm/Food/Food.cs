namespace WildFarm.Food
{
    public abstract class Food : IFood
    {
        protected Food(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public string Name { get; }
        public int Quantity
        { get; }
    }
}