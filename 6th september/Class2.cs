using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep6thasnmnt
{
   
    
        public interface transaction
        {

            void printbalance();
            void calculateinterest();
        }
        public class bank : transaction
        {

            public double amount;

            public bank()
            {

                amount = 0;
            }

            public void printbalance()
            {
                Console.WriteLine("ENTER THE AMOUNT");
                amount = Convert.ToDouble(Console.ReadLine());
            }
            public void calculateinterest()
            {
                int r;
                Console.WriteLine("enter the interest to calculate");
                r = Convert.ToInt32(Console.ReadLine());
                double result = amount * r;
                Console.WriteLine("calc_interest " + result);
            }
        }
    }


