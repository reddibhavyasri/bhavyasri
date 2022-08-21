using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2asnmnt5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.Write("The biggest number is " + a);
            }
            else
                Console.Write("The biggest number is" + b);
        }
    }
}
