using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first Name");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter your Grade");
            string grade = Console.ReadLine();
            StudentInfo db = new StudentInfo();
            Students student = new Students { FName = fName, LName = lName, Grade = grade };
            db.Students.Add(student);
            db.Context.SaveChanges();

            //Displaying all the entries in the database
            var query = from b in db.Students
                        orderby b.FName
                        select b;

            Console.WriteLine("All students in the database:");
            foreach (var item in query)
            {
                Console.WriteLine(item.FName);
                Console.WriteLine(item.LName);
                Console.WriteLine(item.Grade);
            }
            Console.ReadLine();

        }
        public class Students
        {
            public int Id { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
            public string Grade { get; set; }
        }
        public class StudentInfo
        {
            public StudentInfoContext Context { get; set; }
            
            public StudentInfo()
            {
                Context = new StudentInfoContext();
            }

            public DbSet<Students> Students
            {
                get { return Context.Students; }
                set { Context.Students = value; }
            }
        }


        //Defining the DB context class that will inherit from DbContext
        public class StudentInfoContext : DbContext
        {
            public DbSet<Students> Students { get; set; }
        }
    }
}
