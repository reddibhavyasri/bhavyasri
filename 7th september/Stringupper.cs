using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateslibrary
{
    public delegate void toupperDelegate();
   public class Stringupper
    {
        public void toupper()
        {
            string str = "educative";
            if (str.Length == 0)

                Console.WriteLine("Emptystring");

            else if (str.Length == 1)
                Console.WriteLine(char.ToUpper(str[0]));
            else
                Console.WriteLine(char.ToUpper(str[0]) + str.Substring(1));
            Console.ReadLine();
        }
    }
    

    }

