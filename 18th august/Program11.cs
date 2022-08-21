using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prblmst11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if both are positive:");
            Console.WriteLine((i > 0 && j > 0));
            Console.ReadLine();
        }
    }
}
