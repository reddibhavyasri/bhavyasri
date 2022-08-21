using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2asnmnt10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, rev = 0, r;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                r = n % 10;
                rev = rev * 10 + r;
                n /= 10;
            }
            Console.Write("Reverse of given  Number: " + rev);
            Console.ReadLine();
        }
    }
}
