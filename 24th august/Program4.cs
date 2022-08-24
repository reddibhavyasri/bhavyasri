using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    public class Program4
    {
        public static void Stringsplit()
        {
            string str1 = "Welcome to the world of C# Programming";
            string[] sep = { "#", "," };
            int cnt = 2;
            string[] res = str1.Split(sep, cnt, StringSplitOptions.RemoveEmptyEntries);
            foreach(var item in res)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }

        }
    }
}
