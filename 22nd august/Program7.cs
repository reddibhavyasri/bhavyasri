using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22asnmnt7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(2);
            q.Enqueue(4);
            q.Enqueue(6);
            q.Enqueue(10);

            Console.WriteLine("the elements are");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            object obj = q.Dequeue();
            Console.WriteLine(obj);
            Console.WriteLine("After removing element");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The peak element is =" + q.Peek());


            Console.ReadLine();
        }
    }
}
