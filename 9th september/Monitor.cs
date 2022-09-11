using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace sep9thasnmnt1
{
    public  class Monitor
    {
        static object l1 = new object();
        static void PrintTable()
        {

            Thread.Sleep(800);
            WriteToFile();

        }

        static void WriteToFile()
        {
            string threadname = Thread.CurrentThread.Name;
            Console.WriteLine(threadname);
            Monitor.Enter(l1);
            NewMethod();

            void NewMethod()
            {
                try
                {

                    using (FileStream fs = new FileStream("tables.txt", FileMode.Append, FileAccess.Write))
                    {
                        StreamWriter wr = new StreamWriter(fs);
                        wr.WriteLine(threadname);
                        wr.Close();
                        fs.Close();
                    }




                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {


                    Monitor.Exit(l1);
                    Console.WriteLine("Releasing the thread " + threadname);

                }
            }

        }

        private static void Exit(object l1)
        {
       
        }

        private static void Enter(object l1)
        {
           
        }

        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                Thread thread = new Thread(PrintTable);
                thread.Name = string.Concat("thread ", i);
                thread.Start();

            }
            Console.Read();

        }
    }
}
    

