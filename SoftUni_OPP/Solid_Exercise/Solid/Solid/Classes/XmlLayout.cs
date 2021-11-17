using Solid.Interfaces;

namespace Solid.Classes
{
    public class XmlLayout:ILayout
    {
        public XmlLayout()
        {
            Format = 
@"< log >
    < date > {0} </ date >
    < level > {1} </ level >
    < message > {2} </ message >
</ log >";
        }
        public string Format { get; }
    }
}