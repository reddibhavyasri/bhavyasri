using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4th_prblm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;

            Console.Write("Enter the First number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            d = Convert.ToDouble(Console.ReadLine());

            double e = (a+ b + c+ d) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
         a,b, c, d , e);
        }
    }
}
