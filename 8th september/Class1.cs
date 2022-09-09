using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlibrary
{
    public class dept
    {
        private int deptno;
        public int Deptno
        {
            get { return deptno; }
            set { deptno = value; }
        }
        private string deptname;
        public string  Deptname
        {
            get { return deptname; }
            set { deptname = value; }
        }
        private string deptlocation;
        public string Deptlocation
        {
            get { return deptlocation; }
            set
            {
                deptlocation = value;
            }
        }
    }
}
