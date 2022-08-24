using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace newproject
{
    public class Program6
    {
        public static void Firstfile()
        {
            string path = @"C:\Users\User\New folder\Firstfile.txt";
            File.Create(path);
           

        }
    }
}
