using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Example_1.Violation
{
    class MainClass
    {
        // Simple demonstration
        public double CalculateEmployeeSalary(Employee employee)
        {
            double salary = 0;
            double hourlyRate = 15;
            if(employee.Type == EmployeeTypes.Fresh)
            {
                salary = hourlyRate * employee.WorkingHours * 1.0;
            } 
            else if (employee.Type == EmployeeTypes.Junior)
            {
                salary = hourlyRate * employee.WorkingHours * 1.2;
            }

            return salary;
        }

        public void TestMethod()
        {
            Employee employee1 = new Employee("Sael", EmployeeTypes.Fresh, 5);
            Employee employee2 = new Employee("Neil", EmployeeTypes.Junior, 6);

            Console.WriteLine($"{employee1.Name} is {employee1.Type} with salary = {this.CalculateEmployeeSalary(employee1)}");
            Console.WriteLine($"{employee1.Name} is {employee1.Type} with salary = {this.CalculateEmployeeSalary(employee2)}");

            //What happens when we want to add new type of employee ? We have to edit the function CalculateSalary and add to the if-else
            //This will violates that classes should be open for extension but closed for modification (Open-Closed Principle)
            Employee employee3 = new Employee("Mark", EmployeeTypes.Senior, 7); 
            Console.WriteLine($"{employee1.Name} is {employee1.Type} with salary = {this.CalculateEmployeeSalary(employee3)}");
        }
    }
}
