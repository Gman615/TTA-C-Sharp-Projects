using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraFeaturesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // constant variable
            const string name = "Garrett";
            // using var instead of type declaration
            var age = 33;
            Console.WriteLine("Hello, my name is {0}, I am {1} years old", name, age);
            Console.WriteLine("How much money do you have in your pocket?");
            int yourIncome = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your income for the week is $50 and it has been added to your pocket");
            // uses the constructor, first one
            Person person = new Person(yourIncome);
            
            Console.ReadLine();
        }
    }
}
