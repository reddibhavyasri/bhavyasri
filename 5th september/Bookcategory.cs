using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Bookcategory
    {
       
       
        private int catid;
        public int Categoryid
        {
            get { return catid; }
            set { catid = value; }
        }
        private string catname;
        public string Categoryname
        {
            get { return catname; } 
             set { catname = value; }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }
        public Bookcategory()
        {

        }
        public Bookcategory(int catid, string catname, string description)
        {
            this.Categoryid=catid;
            this.Categoryname=catname;
            this.Description=description;
        }
        public void InsertData(int catid, string catname, string description)
        {
            this.Categoryid = catid;
            this.Categoryname = catname;
            this.Description= description;
        }

    }

}
