using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPractice
{
    class Program
    {
        public struct Number 
        {
            public decimal Amount { get; set; }
        }
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 33.33333m;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
