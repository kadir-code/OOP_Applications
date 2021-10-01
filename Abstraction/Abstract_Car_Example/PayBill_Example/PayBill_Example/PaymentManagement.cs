using PayBill_Example.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayBill_Example
{
    public static class PaymentManagement
    {
        //unit price of 1 kw
        public const int KW = 20;
        //unit price of 1 m^3 gas
        public const int GS = 10;

        public static int GetKw(int i)
        {
            return (i);
        }

        public static int GetGS(int i)
        {
            return (i);
        }
        
    }
}
