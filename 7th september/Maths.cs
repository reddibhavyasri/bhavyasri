using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateslibrary
{


    public delegate int mathsDelegate(int a, int b);
    public class Maths
    {
        public int Add(int a, int b)
        {
            Console.WriteLine($"Addition : {a + b}");
            return a + b;
        }
        public int Sub(int a, int b)
        {
            Console.WriteLine($"Subtraction : {a - b}");
            return a - b;
        }
        public int Mul(int a, int b)
        {
            Console.WriteLine($"Multiplication : {a * b}");
            return a * b;
            Console.ReadKey();


        }
    }

    }


