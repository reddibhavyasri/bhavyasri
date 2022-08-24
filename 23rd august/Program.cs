using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug23asnmnt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter first number :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter second number :");
            int b = Convert.ToInt32(Console.ReadLine());
            add(a, b);
            Console.ReadLine();
        }
        static void add(int a, int b)
        {
            Console.Write("\nThe sum of a and b is {0}", a + b);
        }
    }
 }

