using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep6thasnmnt
{
    
    
        public interface banks
        {

            void printbalance();
            void calculateinterest();
        }
        public class savi : banks
        {

            public double amount;

            public savi()
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
                float r = 0.04f;

                double result = amount * r;
                Console.WriteLine("calc_interest " + result);
            }
        }
        public class current : banks
        {

            public double amount;

            public current()
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
                float r = 0.02f;

                double result = amount * r;
                Console.WriteLine("calc_interest " + result);
            }
        }
    }


