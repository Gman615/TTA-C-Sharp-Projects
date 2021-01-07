using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public string ID { get; set; }

        public static Person operator+ (Person person, Employee employee) 
        {
            person.Persons.Add(employee);
            return person;
        }
        public static Person operator- (Person person, Employee employee) 
        {
            person.Persons.Remove(employee);
            return person;
        }

        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit() 
        {
            Console.WriteLine("Thank you for using this app");            ;
        }
    }
}
