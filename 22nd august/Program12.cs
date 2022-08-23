using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22asnmnt12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10, 12, 14 };
            Console.WriteLine("maxminum num is " +  arr.Max());
            Console.WriteLine("Minimum num is " + arr.Min());
            Console.ReadLine();
        }
    }
}
