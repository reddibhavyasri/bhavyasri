using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22asnmnt8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            Console.WriteLine("before deleting from hash table");
            h.Add(1, "orange");
            h.Add(2, "apple");
            h.Add(3, "chacolate");
            h.Add(4, "tamota");
            h.Add(5, "banana");
            IDictionaryEnumerator ie = h.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Key + "  " + ie.Value);
            }
            Console.WriteLine("after deleting from hash table");
            h.Remove(2);
           


            Console.ReadLine();
        }
    }
}
