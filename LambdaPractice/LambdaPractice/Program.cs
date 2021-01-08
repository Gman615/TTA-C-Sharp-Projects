using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            Employee employee = new Employee();
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Markin", ID = 1 });
            employeeList.Add(new Employee { FirstName = "Garrett", LastName = "Aspacher", ID = 2 });
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Rogan", ID = 3 });
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Thomas", ID = 4 });
            employeeList.Add(new Employee { FirstName = "Damian", LastName = "Lillard", ID = 5 });
            employeeList.Add(new Employee { FirstName = "Jamal", LastName = "Murray", ID = 6 });
            employeeList.Add(new Employee { FirstName = "Nikola", LastName = "Jokic", ID = 7 });
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Jones", ID = 8 });
            employeeList.Add(new Employee { FirstName = "Robert", LastName = "Moffatt", ID = 9 });
            employeeList.Add(new Employee { FirstName = "Shaquille", LastName = "O'Neal", ID = 10 });


            List<Employee> joeList = new List<Employee>();
            List<Employee> IDList = new List<Employee>();
            foreach (Employee employees in employeeList)
            {
                
                if (employees.FirstName == "Joe")
                {
                    joeList.Add(employees);
                }

            }
            joeList = employeeList.Where(employees => employees.FirstName == "Joe" ).ToList();
            IDList = employeeList.Where(employees => employees.ID > 5).ToList();            
            Console.ReadLine();
        }
    }
}
