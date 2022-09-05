using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productsclass
{
  
    
        public class Products
        {
            int productid;
            string productname;
            float qtysold;
            int unitprice;
            float unitofmeasurement;
            float qtyinhand;
            int recorderlevel;

            public int Productid
            {
                get { return productid; }
                set { productid = value; }
            }
            public string Productname
            {
                get { return productname; }
                set { productname = value; }
            }
            public float Qtysold
            {
                get { return qtysold; }
                set { qtysold = value; }
            }
            public int Unitprice
            {
                get { return unitprice; }
                set
                {
                    unitprice = value;
                }
            }
            public float Unitofmeasuement
            {
                get { return unitofmeasurement; }
                set { unitofmeasurement = value; }

            }
            public float Qtyinhand
            {
                get { return qtyinhand; }
                set
                {
                    qtyinhand = value;
                }

            }
            public int Recorderlevel
            {
                get { return recorderlevel; }
                set
                {
                    recorderlevel = value;
                }
            }
        }
    }




    

