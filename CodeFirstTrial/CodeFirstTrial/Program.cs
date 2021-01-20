using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext()) 
            {
                Console.WriteLine("Enter the first name of a student.");
                string fName = Console.ReadLine();
                Console.WriteLine("Enter the last name of a student.");
                string lName = Console.ReadLine();
                var student = new Student { FirstName = fName };
                var student1 = new Student { LastName = lName };
                db.StudentInfo.Add(student);
                db.StudentInfo.Add(student1);
            }
        }
        public class Student 
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public virtual List<Student> Students { get; set; }
        }
        public class StudentContext : DbContext 
        { 
            public DbSet<Student> StudentInfo { get; set; }
        }

        
    }
}
