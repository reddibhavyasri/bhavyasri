using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    public  class Program3
    {
        public static void Index()
        {
            string str1 = "hello world";
            Console.WriteLine("The string is : {0}", str1);
            Console.WriteLine("The index of w on str1 is =" + str1.IndexOf("w"));
            int indexofl = str1.IndexOf("l");
            Console.WriteLine("The index of l on str1 is =" + indexofl);
            Console.ReadLine();
        }
    }
}
