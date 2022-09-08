﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateslibrary
{
    public delegate void printproduct(Class4 p);

   
    
    

    public class Class4
    {
        public int Productid { get; set; }
        public string Productname { get; set; }

        public static void Print(Class4 p)
        {
            Console.WriteLine("Product Id : " + p.Productid);
            Console.WriteLine("Product Name : " + p.Productname);
        }
    }
}
