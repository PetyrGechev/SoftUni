namespace Telephony
{
    public class StationaryPhone:Phone
    {
        public override string Call(string number)
        {
            return $"Dialing... {number}";
        }
    }
}