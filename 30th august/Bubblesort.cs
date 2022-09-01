using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug30trainingpractice
{
    internal class Program
    {
        static void Main(string[] args )
        {
            int[] arr = new int[] { 10, 22, 30, 66, 24, 56, 74 };
            SortedBubblesort(arr);
            Console.ReadLine();
            

        }
        static void SortedBubblesort(int[] arr)
        {
         
            int temp;
            for (int i = 0; i < (arr.Length) - 1; i++)
            {
                for (int j = 0; j < (arr.Length - 1) - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array in bubblesort method is");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
              
            }

        }
    }
}
