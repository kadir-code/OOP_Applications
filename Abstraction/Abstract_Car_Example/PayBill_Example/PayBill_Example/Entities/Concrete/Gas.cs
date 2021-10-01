using PayBill_Example.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayBill_Example.Entities.Concrete
{
    class Gas:BaseEntity
    {
        public string BillName { get => "Gas Bill"; }
    }
}
