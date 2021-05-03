using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Example_1.Violation
{
    public class Employee
    {
        public string Name { get; set; }
        public EmployeeTypes Type { get; set; }
        public double WorkingHours { get; set; }
        public Employee(string name, EmployeeTypes type, double workingHours)
        {
            Name = name;
            Type = type;
            WorkingHours = workingHours;
        }
    }
}
