using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace aug23asnmnt4
{
    internal class Class1
    {
        static void Main (string[] args) {

            Employee[] employees = new Employee[2];
            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Enter Employeeno");
                int empno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string ename = Console.ReadLine();
                
                Console.WriteLine("Enter Salary : ");
                double sal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter DeptNo:");
                int deptno = Convert.ToInt32(Console.ReadLine());
                employees[i].AcceptData(empno, ename, sal, deptno);
            }
            for (int i = 0; i < 2; i++)
            {
                employees[i].Display();
            }
            Console.ReadLine();



        }
    }
}