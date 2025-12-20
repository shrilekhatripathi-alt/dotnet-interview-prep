using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day3.ConsoleApp
{
    public class Employee
    {
        public string Name { get; set; }
        public void Work()
        {
            Console.WriteLine($"{Name} is doing gerneral work.");
        }

    }
    public class Manager:Employee
    {
        public void ManageTeam()
        {
            Console.WriteLine($"{Name} is managing team.");
        }
    }
}
