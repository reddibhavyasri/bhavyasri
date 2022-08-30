using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using augasnmntcls2;

namespace aug29asnmnt1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            UserDataStore<string> stringdata = new UserDataStore<string>();
            stringdata.AddOrEdit(0, "India");
            string printdata = stringdata.ReturnData(0);
            Console.WriteLine(printdata);
            Console.WriteLine(" ");
            stringdata.AddOrEdit(0,"russia");
            stringdata.AddOrEdit(1, "canada");
            stringdata.AddOrEdit(2, "london");

            stringdata.ShowData(0);
            stringdata.ShowData(1);
            stringdata.ShowData(2);


            Console.ReadLine();

        }

    }
}



    

