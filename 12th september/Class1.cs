using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Caluculator
    {
        private double number;
        public double Number
        {
            get { return number; }
            set { number = value; }
        }
        public void Cube(double number)
        {
            Number = number;
            double ans = number * number * number;
            Console.WriteLine("The Cube of number is " + ans);
        }
        public void sqrt(double number)
        {
            Number = number;
            Double ans=Math.Sqrt(number);
            Console.WriteLine("The Square root of number is " + ans);


        }
           
        }
    }

