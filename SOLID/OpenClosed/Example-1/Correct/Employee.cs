using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Example_1.Correct
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public double WorkingHours { get; set; }
        public double HourlyRate { get; set; }
        public Employee(string name, double hourlyRate, double workingHours)
        {
            Name = name;
            HourlyRate = hourlyRate;
            WorkingHours = workingHours;
        }
        public abstract double CalculateSalary();
    }
}
