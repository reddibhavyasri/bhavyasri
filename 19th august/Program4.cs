using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2asnmnt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            Console.Write("enter the string");
            str1 = Console.ReadLine();
            Console.Write("enter the another string ");
            str2 = Console.ReadLine();
            if(str1==str2)
            {
                Console.Write("both strings are equal");
            }

        }
    }
}
