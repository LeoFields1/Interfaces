using Interfaces.Interfaces;
using System;

namespace Interfaces
{
    internal partial class Program
    {
        public class Employees : Locations, ILocationStatus
        {
            public int EmployeeId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public DateTime HireDate { get; set; }
            public int JobId { get; set; }
            public int ManagerId { get; set; }
            public int DepartmentId { get; set; }
            public bool IsRemote { get; set; }
            public bool IsOnsite { get; set; }
        }
    }
}
