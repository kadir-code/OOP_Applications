using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayBill_Example.Entities.Abstraction
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        private DateTime _payDate = DateTime.Now;
        public DateTime PayDate { get=>_payDate; set=>_payDate=value; }
    }
}
