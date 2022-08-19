using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstdaypractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5, j = 6;
            callbyswapvalue(i, j);
            Console.WriteLine("but the actual value of i is" +i);
            Console.WriteLine("but the actual value of j is" +j);
     
            Console.WriteLine("=====================");
            callbyswapvaluereference(ref i, ref j);
             Console.WriteLine("but the actual value of i=" +i);
             Console.WriteLine("but the actual value of j=" +j);
             Console.Read();
               
        }
           
        static void callbyswapvalue(int i, int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("value of i" + i);
            Console.WriteLine("value of j" + j);

        }
        static void callbyswapvaluereference(ref int i, ref int j)
        {
                int k = i;
                i = j;
                j = k;
                Console.WriteLine("swapped value of i=" + i);
                Console.WriteLine("swapped value of j=" +j);
                Console.ReadLine();

            

        }
    }
}
