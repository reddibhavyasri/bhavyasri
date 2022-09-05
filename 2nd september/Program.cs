using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sep2asnmnt;
using Productsclass;

namespace sep2asnmnt2
{

    class Program
    {
        static void Main(string[] args)
        { 
       
            Category catr = new Category();
            catr.Categoryid = 12;
            catr.Categoryname = "snacks";
            catr.Description = "These items are new items in cooldrinks";

            Products prodct = new Products();
            prodct.Productid = 12;
            prodct.Productname = "sprite";
            prodct.Qtysold = 120;
            prodct.Unitprice = 124;
            prodct.Unitofmeasuement = 124;
            prodct.Qtyinhand = 400;
            prodct.Recorderlevel = 126;

            

            Console.WriteLine("Category details ");
            Console.WriteLine(  catr.Categoryid);
            Console.WriteLine(  catr.Categoryname);
            Console.WriteLine(  catr.Description);
            Console.WriteLine("===========================================");
            Console.WriteLine("Products details");
            Console.WriteLine(prodct.Productid);
            Console.WriteLine( prodct.Productname);
            Console.WriteLine(prodct.Qtysold);
            Console.WriteLine( prodct.Unitprice);
            Console.WriteLine( prodct.Unitofmeasuement);
            Console.WriteLine( prodct.Qtyinhand);
            Console.WriteLine(prodct.Recorderlevel);
            Console.ReadLine();
        }

    }
}

