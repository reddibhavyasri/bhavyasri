using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2asnmnt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
           
            Console.Write("Input the 1st number :");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            j= Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            k = Convert.ToInt32(Console.ReadLine());

            if (i>j)
            {
                if (i>k)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (j>k)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
            Console.ReadLine();

        }
    }
}
