using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books;

namespace sep5thasnmnt1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Booksclass book = new Booksclass(1, "abcd", 120);
            Console.WriteLine("Book  id : {0}, Book Name : {1}, Book Price : {2}", book.BookId, book.BookName, book.BookPrice);
            Booksclass book2 = new Booksclass(2, "dreams", 200, "riya");
            Console.WriteLine("BookId :{0},BookName:{1},BookPrice:{2},Authour:{3}", book2.BookId, book2.BookName, book2.BookPrice, book2.Authr);
            Booksclass book6 = new Booksclass(6, "arts");
            Console.WriteLine("BookId :{0},BookName:{1}", book6.BookId, book6.BookName);
            Bookcategory bookcategory = new Bookcategory(12,"motivation", "Famous Books");
            Console.WriteLine("CategoryId :{0},CategoryName :{1},CategoryDescription :{2}",bookcategory.Categoryid,bookcategory.Categoryname,bookcategory.Description);




            Console.ReadKey();
        }
    }
}
