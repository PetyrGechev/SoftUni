namespace Solid.Interfaces

{
    public interface ILayout
    {
        //"<date-time> - <report level> - <message>"
        public string Format { get; }
    }
}