using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug23asnmnt4
{
    internal class Program
    {
    }

    struct Employee
    {
        public int empno;
        public string ename;
        public double sal;
        public int deptno;
        public void AcceptData(int empno, string ename, double sal, int deptno)
        {
            this.empno = empno;
            this.ename = ename;
            this.sal = sal;
            this.deptno = deptno;
        }
        public void Display()
        {
            Console.WriteLine("Employee no :{0} ", this.empno);
            Console.WriteLine("Employee name:{0}", this.ename);
            Console.WriteLine("Employee sal:{0}", this.sal);
            Console.WriteLine("Employee deptno :{0}", this.deptno);
            Console.ReadLine();

        }
    }

}

