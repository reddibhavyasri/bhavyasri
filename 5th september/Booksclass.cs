using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Booksclass
    {
      public Booksclass(int BookId)
        {
            bookid = BookId;
        }

        
       
        private int bookid;
        public int BookId
        {
            get { return bookid; }
            set { bookid = value; }
        }
        private string bookname;
        public string BookName
        {
            get { return bookname; }
            set { bookname = value; }
        }
        private int bookprice;
        public int BookPrice
        {
            get { return bookprice; }
            set { bookprice = value; }
        }
        private string authr;
        public string Authr
        {
            get { return authr; }
            set { authr = value; }
        }

        public string V { get; }

        //default constructor//
        public Booksclass() { }
        //pameterizecd constructor//
        public Booksclass(int bookid,string bookname,int bookprice)
        {
            this.BookId= bookid; 
            this.BookName= bookname;
             this.BookPrice= bookprice;  
        }
        public Booksclass(int bookid, string bookname, int bookprice, string authr)
        {
            this.BookId = bookid;
            this.BookName = bookname;
            this.BookPrice = bookprice;
            this.Authr = authr;


        }
        public Booksclass(int bookid, string bookname)
        {
            this.BookId = bookid;
            this.BookName = bookname;

        }

        

        public void InsertData(int bookid, string bookname, int bookprice)
        {
            this.BookId = bookid;
            this.BookName = bookname;
            this.BookPrice = bookprice;
            

        }
        public void InsertData(int bookid, string bookname, int bookprice,string authr)
        {
            this.BookId = bookid;
            this.BookName=bookname; 
            this.BookPrice=bookprice;
            this.Authr = authr;

        }
        public void InsertData(int bookid, string bookname)
        {
            this.BookId = bookid;
            this.BookName = bookname;
        }
    }
}