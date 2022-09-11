using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace sep9thasnmnt1
{
    public class ThreadPriority
    {
        static void print()
        {


            Console.WriteLine("hello all");
            
        }
        static void print1()
        {
            Console.WriteLine("HELLO");
        }
        static void print2()
        {
            Console.WriteLine("world");

        }
        static void print3()
        {
            Console.WriteLine("hi everyone");
        }
        static void print4()
        {
            Console.WriteLine("hi ");
        }

        private static void Main(string[] args)
        {
            Thread t1 = new Thread(print);
            Thread t2 = new Thread(print2);
            Thread t3 = new Thread(print3);
            Thread t4 = new Thread(print4);
            Console.WriteLine("befoe start");
            Console.WriteLine("Is t1 alive :" + t1.IsAlive);
            t1.Start();
            Console.WriteLine("after start");
            Console.WriteLine("Is T1 alive" + t1.IsAlive);
            Console.WriteLine("befoe start");
            Console.WriteLine("Is t2 alive :" + t2.IsAlive);
            t2.Start();
            Console.WriteLine("after start");
            Console.WriteLine("Is T2 alive" + t2.IsAlive);
            Console.WriteLine("befoe start");
            Console.WriteLine("Is t3 alive :" + t3.IsAlive);
            t3.Start();
            Console.WriteLine("after start");
            Console.WriteLine("Is t3 alive :" + t3.IsAlive);
            Console.WriteLine("before start");
            Console.WriteLine("Is t4 alive :"+ t4.IsAlive);
            t4.Start();
            Console.WriteLine("after start");
           Console.WriteLine("Is T4 is alive :"+t4.IsAlive);



          
        
            t1.Priority= System.Threading.ThreadPriority.BelowNormal;
            t2.Priority = System.Threading.ThreadPriority.Normal;
            t3.Priority = System.Threading.ThreadPriority.Highest;
            t4.Priority = System.Threading.ThreadPriority.Lowest;
            Console.Read();
        }
      
    }
}

