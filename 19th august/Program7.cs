using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2asnmnt7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, totalmarks;
            float per;
            string grade;
            Console.Write("enter the first subject marks : ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the second subject marks : ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the third subject marks : ");
            sub3 = Convert.ToInt32(Console.ReadLine());

            totalmarks = sub1 + sub2 + sub3;
            per = totalmarks / 3.0f;
            if (per > 60)
                grade = "First";
            else
            if (per >= 45 && per <= 60)
                grade = "Second";

            else
                if (per < 45 && per >= 35)
                grade = "Third";
            else
                grade = "Fail";

            Console.Write("Total Marks = {0}\nPercentage = {1}\n Grade = {2}\n", totalmarks, per, grade);
            Console.ReadLine();
        }
    }
}
