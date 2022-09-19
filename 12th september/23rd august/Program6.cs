using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug23asnmnt6
{
    internal class Program
    {
        enum Deptnames
        {
            Purchases,
            Sales,
            Training,
            Accounts,
        }

        static void Main(string[] args)
        {
            int num = (int)Deptnames.Accounts;
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
    }

