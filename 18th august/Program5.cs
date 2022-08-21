using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prblm_asnmnt
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int a, b, c;

            Console.Write("Enter first number - ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number - ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number - ");
           c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
                a, b, c, ((a + b) * c), (a * b+ b *c));
            Console.ReadLine();
        }
    }
    
}
