using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22asnmnts5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            int[][] classofst = new int[6][];
            {
                classofst[0] = new int[4] { 1, 2, 3, 4 };
                classofst[1] = new int[6] { 1, 2, 3, 4, 5, 6 };
                classofst[2] = new int[6] { 1, 2, 3, 4, 5, 6 };
                classofst[3] = new int[1] { 1 };
                classofst[4] = new int[6] { 1, 2, 3, 4, 5, 6 };

                classofst[5] = new int[4] { 1, 2, 3, 4 };

                for (int i = 0; i < classofst.Length; i++)
                {
                    System.Console.Write("Element({0}): ", i + 1);
                    for (int j = 0; j < classofst[i].Length; j++)
                    {
                        System.Console.Write(classofst[i][j] + "\t");
                    }
                    System.Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
