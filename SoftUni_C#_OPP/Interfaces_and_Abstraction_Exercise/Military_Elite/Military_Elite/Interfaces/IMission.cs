namespace Military_Elite.Interfaces
{
    public interface IMission
    {
        //mission holds a code name and a state (inProgress or Finished).
        //A Mission can be finished through the method CompleteMission().
        public string CodeName { get; }
        public State State { get; set; }
    }
}