using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanciationPractice
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // method created that uses properties from the class
        public void SayName() 
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
