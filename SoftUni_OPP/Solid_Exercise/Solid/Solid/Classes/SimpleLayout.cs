using Solid.Interfaces;
namespace Solid.Classes
{
    public class SimpleLayout : ILayout
    {
        //"<date-time> - <report level> - <message>"
        public SimpleLayout()
        {
            Format = "{0} - {1} -{2}";
        }

        public string Format { get; private set; }

    }
}