using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep6thasnmnt
{
    abstract class Person
    {
        public abstract void work();
    }

      public   class Employee : Person
        {
            public override void work()
            {
                Console.WriteLine("This is an employee work");
            }

        }
     public   class Manager:Person
    {
      public   override void work()
        {
            Console.WriteLine("This is manager work");
        }
    }
    public    class Clerk : Person
    {
        public override void work()
        {
            Console.WriteLine("This is the work for a clerk");
        }
    }
}