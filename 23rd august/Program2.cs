using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug23asnmnt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter first number :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter second number :");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nThe sum is {0} ", add(a, b));
            Console.ReadLine();
        }
        static int add(int a, int b)
        {
            return a + b;
        }
    }
    }

