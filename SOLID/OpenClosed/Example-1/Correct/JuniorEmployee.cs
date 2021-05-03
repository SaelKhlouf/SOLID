using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Example_1.Correct
{
    public class JuniorEmployee : Employee
    {
        public JuniorEmployee(string name, double hourlyRate, double workingHours) : base(name, hourlyRate, workingHours)
        {
        }

        public override double CalculateSalary()
        {
            return this.WorkingHours * this.WorkingHours * 1.4;
        }
    }
}
