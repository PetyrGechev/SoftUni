namespace Military_Elite.Interfaces
{
    public interface IRepair
    {
        //part name and hours worked(int).
        public string PartName { get; }
        public int HoursWorked { get; }
    }
}