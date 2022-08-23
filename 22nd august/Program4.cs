using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22asnmnt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            a.Add(5);
            a.Add(6);
            Console.WriteLine("The array list is :");
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The count of elements in arraylist :" + a.Count);
            a.Remove(2);
            Console.WriteLine("The count of elements in arraylist after removing:");
            foreach (int i in a )
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("count after removing elements :" + a.Count);
            Console.ReadLine();
            

           
        }
    }
}
