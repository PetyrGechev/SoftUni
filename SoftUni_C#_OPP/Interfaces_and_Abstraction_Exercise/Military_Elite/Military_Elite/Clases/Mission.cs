using Military_Elite.Interfaces;

namespace Military_Elite.Clases
{
    public class Mission:IMission
    {
        public Mission(string codeName, State state)
        {
            CodeName = codeName;
            State = state;
        }

        public string CodeName { get; }
        public State State { get; set; }
        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}