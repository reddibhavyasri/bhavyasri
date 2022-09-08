using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateslibrary
{

    public delegate void stringlengthDeligate();
    public class stringlen
    {
        public void stringlength()

        {
            string str = "riya";
            Console.WriteLine("The length of the string is :" + str.Length);
            Console.ReadLine();
           
        }
    }
}
        