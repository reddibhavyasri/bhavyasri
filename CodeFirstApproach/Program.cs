using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstDALDemo;

namespace CodeFirstApproach
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            context.studentsTable.Add(new Student{ Rollno=1,Studname="ananth"});
            context.SaveChanges();
            Console.WriteLine("Done");
            Console.ReadLine(); 
        }
    }
}
