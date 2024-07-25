using System;
using Interfaces.Interfaces;

namespace Interfaces
{
    internal partial class Program
    {
        public class Locations : IOnsiteWorker, IRemoteWorker
        {
            public int LocationId { get; set; }
            public string StreetAddress { get; set; }
            public int PostalCode { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int CountryId { get; set; }

            public void Onsite()
            {
                Console.WriteLine($"Worksite: Onsite");
            }

            public void Remote()
            {
                Console.WriteLine($"Worksite: Remote");
            }
        }
    }
}
