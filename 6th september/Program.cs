using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Intuit.Ipp.Data;
using sep6thasnmnt;

namespace sep6thasnmnt1
{


   
  public  class program
    {
        static void Main(string[] args)
        {
          
            Employee emp= new Employee();
            emp.work();
            Manager manager= new Manager();
            manager.work();
            Clerk clerk=new Clerk();
            clerk.work();
            
            Console.WriteLine("==================================");
            bank b1 = new bank();
            b1.printbalance();
            b1.calculateinterest();  
            //2 problemstatement
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("savings account");
            banks b = new savi();
            b.printbalance();
            b.calculateinterest();
            Console.WriteLine("current aacount");
            banks b2 = new current();
            b2.printbalance();
            b2.calculateinterest(); 
            //3   and 4 prblmstatements 
            Console.WriteLine("-----------------------------------------");
            bankss g = new bankss();



            g.current();
            g.savings();
            g.deposits();
            g.withdraw();
            g.total_balc();
            g.deposits1();
            g.withdraw1();
            g.total_balc1();        
            //5  and 6 problem statements  


            Console.WriteLine("-----------------------------------------");





        }
    }
}




        
    


        
       
    


    

