using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateslibrary
{
    public delegate void  GreetDelegate(string username);
    public  class Class2
    {
        public void Greet(string username)
        {
           Console.WriteLine("Enter user name");
            username=Console.ReadLine();
           
            Console.WriteLine("hello" + username);
            Console.ReadLine();
        }
    }
}
