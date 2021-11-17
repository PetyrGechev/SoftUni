namespace Solid.Interfaces
{
    public interface ILogFile
    {
        public int Size { get;}

        void Write(string message);
    }
}