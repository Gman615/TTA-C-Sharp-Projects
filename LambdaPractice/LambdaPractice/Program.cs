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
            //creates a new list named employeeList
            List<Employee> employeeList = new List<Employee>();
            Employee employee = new Employee();
            // adds items to the List of Employees
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

            //creates empty ID list and list of guys named Joe
            List<Employee> joeList = new List<Employee>();
            List<Employee> IDList = new List<Employee>();
            //foreach loop that iterates through list of employees, finds employees with the first name Joe and adds them to the list of Joes
            foreach (Employee employees in employeeList)
            {
                
                if (employees.FirstName == "Joe")
                {
                    joeList.Add(employees);
                }

            }
            //does the same thing as foreach loop, instead is a simpler Lambda function that finds employees with the first name Joe and puts them in the list of Joes.
            joeList = employeeList.Where(employees => employees.FirstName == "Joe" ).ToList();
            //does the same thing as foreach loop, instead is a simpler Lambda function that finds employees with the first name Joe and puts them in the list of IDs.
            IDList = employeeList.Where(employees => employees.ID > 5).ToList();            
            Console.ReadLine();
        }
    }
}
