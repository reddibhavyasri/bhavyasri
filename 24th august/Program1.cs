using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    public class sampleclass
    {
        public static void Greet()
        {
            Console.WriteLine("hello to the project");
            string s1 = "benglr";
            int len1 = s1.Length;
            Console.WriteLine("len of s1 :" + len1);
            string s2 = "benglr";
            int len2 = s2.Length;
            Console.WriteLine("len of s2 :" + len2);
            if (len1 == len2)
            {
                Console.WriteLine("lengths of both strings are equal");
               
            }
            else
                Console.WriteLine("lengths are not equal");
                 Console.ReadLine();
            

        }
        

        
    }
}
