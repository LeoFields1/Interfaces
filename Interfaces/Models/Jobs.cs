namespace Interfaces
{
    internal partial class Program
    {
        public class Jobs : Employees
        {
            public int JobId { get; set; }
            public string JobTitle { get; set; }
            public decimal MinSalary { get; set; }
            public decimal MaxSalary { get; set; }
        }
    }
}
