using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace sep9thasnmnt1
{
    public  class Semaphore
    {
        static Thread[] threads = new Thread[10];
        static Semaphore sem = new Semaphore(3, 3);
        private int v1;
        private int v2;

        public Semaphore(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        static void M1()
        {
            Console.WriteLine("{0} is waiting in line...", Thread.CurrentThread.Name);
            sem.WaitOne();
            Console.WriteLine("{0} enters the code", Thread.CurrentThread.Name);
            Thread.Sleep(300);
            Console.WriteLine("{0} is leaving the code", Thread.CurrentThread.Name);
            sem.Release();
        }

        private void Release()
        {
            throw new NotImplementedException();
        }

        private void WaitOne()
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(M1);
                threads[i].Name = "thread_" + i;
                threads[i].Start();
            }
            Console.Read();
        }
    }
}
    

