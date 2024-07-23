using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            List<IRemoteWorker> remoteWorkers = new List<IRemoteWorker>();
            List<IOnsiteWorker> onsiteWorkers = new List<IOnsiteWorker>();

            List<Jobs> jobList = new List<Jobs>
            {
                new Jobs
                {
                JobId = 1,
                JobTitle = "Software Engineer",
                MinSalary = 60000m,
                MaxSalary = 120000m,
                
                 },
                new Jobs
                {
                JobId = 2,
                JobTitle = "Product Manager",
                MinSalary = 70000m,
                MaxSalary = 140000m,
                },
                new Jobs
                {
                JobId = 3,
                JobTitle = "UI/UX Designer",
                MinSalary = 50000m,
                MaxSalary = 100000m,
                },
                new Jobs
                {
                JobId = 4,
                JobTitle = "DevOps Engineer",
                MinSalary = 65000m,
                MaxSalary = 130000m,

                }
            };

            foreach( var item in jobList)
            {
                Console.WriteLine($"{item.JobId}, {item.JobTitle}");
            }
            Console.ReadLine();


            List<Employees> employees = new List<Employees>();

            var developer = new Employees { EmployeeId = 0001, FirstName = "Leotis", LastName = "Fields"};

            Console.WriteLine("Does this employee work (remote) or (onsite)");
            string locationStatus = Console.ReadLine();
            if (locationStatus.ToLower() == "remote")
            {
                developer.IsRemote = true;
                
            }

                employees.Add(developer);
                //remoteWorkers.Add(developer);


            

           foreach(var item in employees)
            {
               
                if(item.IsRemote == true)
                {
                    Console.WriteLine($" Name: {item.FirstName}, {item.LastName}, Location Status: Remote");
                }
                else
                {
                    Console.WriteLine($" Name: {item.FirstName}, {item.LastName}, Location Status: Onsite");
                }
            }
            Console.ReadLine();


        }
    }
}
