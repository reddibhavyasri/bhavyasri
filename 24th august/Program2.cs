using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    public class Program2
    {
        public static void Copy()
        {
            string str1 = "hello";
            string str2 = string.Copy(str1);
            Console.WriteLine("The original  string is  str1 :{0}", str1);
            Console.WriteLine("The  copied string  is str2 :{0} ",str2);
            Console.ReadLine();
        }

    }
}
