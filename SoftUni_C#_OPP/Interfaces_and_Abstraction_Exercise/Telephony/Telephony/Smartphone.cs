namespace Telephony
{
    public class Smartphone:Phone,IBrawse
    {
        public override string Call(string number)
        {
            return $"Calling... {number}";
        }

        public string Browse(string webSite)
        {
            return $"Browsing: {webSite}!";
        }
    }
}