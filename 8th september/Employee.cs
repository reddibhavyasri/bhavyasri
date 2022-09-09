using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Classlibrary
{
    public class Employee
    {
        private int empid;
        public int Empid
        {
            get { return empid; }
            set
            {
                empid = value;
            }
        }
        private string empname;
        public string Empname
        {
            get { return empname; }
            set
            {
                empname = value;
            }
        }
        private int deptno;
        public int Deptno
        {
            get { return deptno; }
            set
            {
                deptno = value;
            }   
        }
        private int sal;
        public int Sal
        {
            get { return sal; }
            set
            {
                sal = value;
            }
        }

        private string mgr;
        public string Mgr
        {
            get { return mgr; }
            set
            {
                mgr = value;
            }
        }
    }
}
