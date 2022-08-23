using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22asnmnt6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Console.WriteLine("before pop");
            stack.Push(2);
            stack.Push(4);
            stack.Push(6);
            foreach (int j in stack)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("after pop");
            stack.Pop();
            foreach (int j in stack)
            {
                Console.WriteLine(j);
            }
            int cnt = stack.Count;
            bool ans = stack.Contains(2);
            Console.WriteLine("Is 2 available on the stack= " + ans);
           
            Console.WriteLine(stack.Count);


            Console.WriteLine("Element at the top of the stack  is : " + stack.Peek());


            Console.ReadKey();
        }
    }
    }

