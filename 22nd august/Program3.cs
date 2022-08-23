using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22asnmnt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            int[] arr = new int[100];
            Console.Write("the num of input elements in the array are :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input {0} number of elements in the array are :" + n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum = sum + arr[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
            Console.ReadLine();
        }
    }

}
    
