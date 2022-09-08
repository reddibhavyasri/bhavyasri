using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateslibrary
{
    public delegate void concat();
    public class Class6
    {
        public void Concat()
        {
            string str1 = "hello ";
            string str2 = " world ";
            string str;

            // print all strings
            Console.WriteLine("String 1 is: {0}", str1);
            Console.WriteLine("String 2 is: {0}", str2);

            // Concatenate two different strings
            // into a single String
          
            str = String.Concat(str1, str2);

            Console.WriteLine("Concatenated string is: {0}", str);
        }
    }
}
