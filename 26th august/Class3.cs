using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug26cls3
{
   
    

        public class Products
        {
            private int _pid;

            public int PID
            {
                get { return _pid; }
                set { _pid = value; }
            }


            private string _pname;

            public string PName
            {
                get { return _pname; }
                set { _pname = value; }
            }

            //fully implemented property----do any validations
            private int _deptno;

            public int DeptNo
            {
                get { return _deptno; }
                set
                {
                    try
                    {

                        if (value != 0)
                        {
                            _deptno = value;
                        }
                        else
                        {
                            //Console.WriteLine("Deptno cannot be 0 or null");
                            throw new ArgumentNullException("Deptno cannot be zero or null");
                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }


                }
            }





        }
    }


