using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLogicLayer3;

namespace BusinessLogicLayer3
{
     public class Bookoperations
    {
        public List<book> GetBooks()
        {
            septemberasnmntEntities1 context = new septemberasnmntEntities1();
            return context.books.ToList();
        }
    }
}
