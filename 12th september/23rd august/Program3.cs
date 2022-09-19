using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug23asnmnt3
{
    
       
        
            struct Employee
        {
            int empno;
            public int Empno
            {
                set { empno = value; }

                get { return empno; }

            }
            string ename;
            public string Ename
            {
                set { ename = value; }
                get { return ename; }

            }

            int sal;
            public int Sal
            {
                set { sal = value; }
                get { return sal; }
            }

            int deptno;
            public int Deptno
            {
                set { deptno = value; }
                get { return deptno; }
            }



        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.Empno = 12;
                emp.Ename = "deepu";
                emp.Sal = 60000;
                emp.Deptno = 66;
                Console.WriteLine("Employee no :" + emp.Empno);
                Console.WriteLine("Employee name :" + emp.Ename);
                Console.WriteLine("Employee sal :" + emp.Sal);
                Console.WriteLine("Employee deptno :" + emp.Deptno);
                Console.ReadLine();
                

            }

        }
    }
    

