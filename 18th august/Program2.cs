using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_prblm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Input the first number to multiply: ");
            a= Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            b= Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            c = Convert.ToInt32(Console.ReadLine());

            int result = a * b * c;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                                a, b , c,  result);
        }
    }
}
