using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug26asnmnt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                LinkedList<string> mylist = new LinkedList<string>();
            mylist.AddFirst("ab");
                mylist.AddLast("mouni");
                mylist.AddAfter(mylist.First, "abcf");
            mylist.AddBefore(mylist.Last, "navy");
                mylist.AddBefore(mylist.Last.Previous, "anu");
            mylist.AddAfter(mylist.First.Next, "renu");
                LinkedListNode<string> foundnode = mylist.Find("renu");
            foundnode.Value = "rthj";



                foreach (var item in mylist)
                {
                    Console.WriteLine(item);

                }
                Console.ReadKey();
            }
        }
    }

