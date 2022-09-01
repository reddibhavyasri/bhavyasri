using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug30trainingpractice
{
     class Selectionsort
    {


        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 41, 3, 12, 57, 13, 69, 23, 56 };
            Selectionsortorder(arr);
            Console.Read();

        }
        static void Selectionsortorder(int[] arr)
        {

            int MinIndex, i, j;
            int len = arr.Length - 1;
            for (i = 0; i < len; i++)
            {
                MinIndex = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[MinIndex])
                    {
                        MinIndex = j;
                    }
                }
                if (MinIndex != i)
                {
                    int temp = arr[MinIndex];
                    arr[MinIndex] = arr[i];
                    arr[i] = temp;
                }
            }

            Console.WriteLine("Sorted array in selectionsort ");
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
            Console.Read();

        }
    }
}


