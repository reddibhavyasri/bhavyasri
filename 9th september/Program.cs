
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace sep9thasnmnt1
{
    public  class Program
    {
        public static void print()
        {
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(i);
            }
        }
        
            
             public static void print12 ()
            {
            Console.WriteLine("This is printstatement2");

            }
        static void Main(string[] args)
        {
            Thread th = new Thread(print);
            th.Name = "newthread";
            th.Start();
            Thread t2= new Thread(new ThreadStart(print12));
            Console.Read();
        }
    }
}
