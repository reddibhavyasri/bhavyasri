using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegateslibrary;

namespace sep7thasnmnt1
{
    public class Program
    {
        static void Main(string[] args)
        {
           stringlen strl = new stringlen();
            stringlengthDeligate strld = new stringlengthDeligate(strl.stringlength);
            strld.Invoke();
            //2nd prblm//
            Class2 cls2 = new Class2();
            GreetDelegate greetdelegate = new GreetDelegate(cls2.Greet);
            greetdelegate.Invoke("anitha");

            //3rd prblm//
            Maths m = new Maths();
            mathsDelegate[] t = new mathsDelegate[3] { m.Add, m.Sub, m.Mul };
            mathsDelegate k = (mathsDelegate)MulticastDelegate.Combine(t);
            k(20, 60);
            //4th prblm//
            Class4 product=new Class4();
            Class4 p1 = new Class4() { Productid = 1, Productname = "Fruits" };
            Class4 p2 = new Class4() { Productid = 2, Productname = "Chocolate" };
            Class4 p3 = new Class4() { Productid = 3, Productname = "colldrinks" };
            Class4 p4 = new Class4() { Productid = 4, Productname = "snacks" };
            printproduct p = new printproduct(Class4.Print);
            p(p1);
            p(p2);
            p(p3);
            p(p4);
            //5th prblm//



            Class5 emp = new Class5() { joiningYear = 2016 };
            Class5 emp1 = new Class5() { joiningYear = 2004 };
            Class5 emp2 = new Class5() { joiningYear = 2006 };


                  join j = delegate (Class5 e) { return DateTime.Now.Year - e.joiningYear; };
            int employee1 = j(emp);
            Console.WriteLine("years of service : " + employee1);
            int employee2 = j(emp1);
            Console.WriteLine("years of service : " + employee2);
            int employee4 = j(emp2);
            Console.WriteLine("years of service : " + employee4);
            //prblm statement6//
            Class6 S = new Class6();
            concat C = new concat(S.Concat);
            C();


            //prblm statement 7//
            Stringupper tpr = new Stringupper();
            toupperDelegate d=new toupperDelegate(tpr.toupper);
            d.Invoke();
           

        }
    }

}
