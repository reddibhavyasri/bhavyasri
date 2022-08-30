using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aug26cls3;

namespace aug26asnmnt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> plist = new List<Products>();
            plist.Add(new Products { PID = 1, PName = "renu", DeptNo = 10 });





            Products p1 = new Products();
            p1.PID = 2;
            p1.PName = "deepu";

            p1.DeptNo = 20;

            plist.Add(p1);
            Products p2 = new Products();
            p2.PID = 3;
            p2.PName = "priya";
            p2.DeptNo = 30;
            plist.Add(p2);



            foreach (var item in plist)
            {
                Console.WriteLine(item.PID);
                Console.WriteLine(item.PName);
                Console.WriteLine(item.DeptNo);

            }
            // plist.Remove(new Products { PID = 1, PName = "Akhil", DeptNo = 10 });
            Console.WriteLine(plist.Count);
            plist.Remove(p1);
            Console.WriteLine("After removing the product");
            foreach (var item in plist)
            {
                Console.WriteLine(item.PID);
                Console.WriteLine(item.PName);
                Console.WriteLine(item.DeptNo);

            }
            Console.WriteLine(plist.Count);
            //plist.Remove(new Products { PID = 1, PName = "Akhil", DeptNo = 10 });

            Console.WriteLine("removed successfully");


            Console.ReadLine();
        }
    }
}
        
    

