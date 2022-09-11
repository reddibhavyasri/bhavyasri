using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sep9thasnmnt1
{
     class ThreadStates
    {
        static void MyThreadMethod()
        {
            Console.WriteLine("The current thread which is running = " + Thread.CurrentThread.Name);
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Method  ={0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("My thread Method ends");
        }
        static void Main(string[] args)
        {

            Thread t1 = new Thread(MyThreadMethod);
            t1.Name = "MyThread";
            t1.Start();
            Console.WriteLine("ThreadState : {0}", t1.ThreadState);
            //suspended state
            t1.Suspend();
            Console.WriteLine("Threadstate {0}", t1.ThreadState);
            //resume to running state
            t1.Resume();
            Console.WriteLine("Threadstate {0}", t1.ThreadState);
            //join state
            t1.Join();
            Console.WriteLine("ThreadState{0}", t1.ThreadState);


        }
        }
    }
