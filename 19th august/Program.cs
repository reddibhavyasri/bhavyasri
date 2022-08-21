using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2asnmnt1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int i;
            int j;

            int maxnum;

            int minnum;

           
            Console.Write("Enter first number : ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            j = Convert.ToInt32(Console.ReadLine());

            if (i > j)
                maxnum = i;

            else
                maxnum = j;


            if (i < j)
                minnum = i;
            else
                minnum = j;


            
            Console.WriteLine("to find maxnum and minnum between two number");
            Console.WriteLine("Minimum number = {0}", maxnum);
            Console.WriteLine("Maximum number = {0}", minnum);
            console.readline();
        }
    }
}
