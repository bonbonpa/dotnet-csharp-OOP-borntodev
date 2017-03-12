using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BornToDev_Static_Test
{
    class VatCaculator
    {   
        //private string a = "test";
        public static double TotalPrice(double price,double vat) //ระดับ class ไม่ต้อง ประกาศ object
        {
            //string b = a;
            //static ไม่สามารถ เรียกใช้ non static ได้
            return ((price*vat)/100)+price;
        }
        public static double VatCalculate(double price, double vat)
        {
            return ((price * vat) / 100);
        }
    }
}
