using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22asnmnt10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "mouni");
            dic.Add(2, "pavani");
            dic.Add(3, "meena");
            dic.Add(4, "renu");

            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.ReadKey();

        }
    }
}
