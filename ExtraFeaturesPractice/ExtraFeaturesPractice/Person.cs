using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraFeaturesPractice
{
    public class Person
    {
        public Person(int money): this(money, 50)
        {
        }
        public Person(int money, int income)
        {
            int pocket = money + income;
            Console.WriteLine("Your total in pocket is {0}", pocket);
        }      

        
            
        

    }
}
