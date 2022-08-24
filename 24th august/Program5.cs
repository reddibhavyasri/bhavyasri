using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    public class Program5
    {
        public static void Uppercase()
        {
            string str1 = "hello world";
            string  str2 = str1.ToUpper();
            Console.WriteLine("The string str1 is " + str1);
            Console.WriteLine("The converted string is str2 {0}:", str2);
            Console.ReadLine();
        }
    }
}
