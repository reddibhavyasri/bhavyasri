using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep2asnmnt
{
    public class Category
    {
        int catid;
        string catname;
        string description;

        public int Categoryid
        {
            get { return catid; }
            set { catid = value; }
        }
        public string Categoryname
        {
            get { return catname; }
            set { catname = value; }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }
    }
}