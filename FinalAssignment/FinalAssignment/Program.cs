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
            var studentFName = new Students { FName = fName };
            db.Studentss.Add(studentFName);
            var studentLName = new Students { LName = lName };
            db.Studentss.Add(studentLName);
            var studentGrade = new Students { Grade = grade };
            db.Studentss.Add(studentGrade);
            db.SaveChanges();

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
            public string FName { get; set; }
            public string LName { get; set; }
            public string Grade { get; set; }
        }
        public class StudentInfo
        {
            public DbSet<Students> Studentss { get; set; }
        }
    }
}
