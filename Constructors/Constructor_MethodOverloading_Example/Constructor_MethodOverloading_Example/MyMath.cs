using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_MethodOverloading_Example
{
    public class MyMath
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }

        public MyMath()
        {

        }
        public  MyMath(int n1,int n2)
        {
            this.Number1 = n1;
            this.Number2 = n2;

        }

        public MyMath(int n1,int n2,int n3)
        {
            this.Number1 = n1;
            this.Number2 = n2;
            this.Number3 = n3;
        }
    }
}
