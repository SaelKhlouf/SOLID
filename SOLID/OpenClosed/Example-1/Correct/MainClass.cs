using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Example_1.Correct
{
    public class MainClass
    {
        public void TestMethod()
        {
            Employee employee1 = new FreshEmployee("Sael", 15 , 5);
            Employee employee2 = new JuniorEmployee("Neil", 15, 6);

            Console.WriteLine($"{employee1.Name} is {employee1.GetType().Name} with salary = {employee1.CalculateSalary()}");
            Console.WriteLine($"{employee1.Name} is {employee2.GetType().Name} with salary = {employee2.CalculateSalary()}");

            //What happens when we want to add new type of employee ? We DO NOT have to edit the function CalculateSalary and add to the if-else
            //We can make a new class that extends the Employee abstract class, and then we are ready to go.
            Employee employee3 = new SeniorEmployee("Mark", 15, 7);
            Console.WriteLine($"{employee1.Name} is {employee3.GetType().Name} with salary = {employee3.CalculateSalary()}");
        }
    }
}
