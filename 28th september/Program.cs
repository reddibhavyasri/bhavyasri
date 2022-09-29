using BusinessLogicLayer3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer3;
using DataAccessLogicLayer3;
namespace Sep28thasnmnt1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bookoperations bookoperations = new Bookoperations();
          List<book>booklist = bookoperations.GetBooks();
            foreach(var item in booklist)
            {
                Console.WriteLine(item.book_no);
                Console.WriteLine(item.book_name);
                Console.WriteLine(item.author);
                Console.WriteLine(item.cost);
                Console.WriteLine(item.category);
            }
            Console.ReadLine();
        }
    }
}
