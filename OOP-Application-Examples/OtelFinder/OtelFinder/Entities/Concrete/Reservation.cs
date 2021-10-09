using OtelFinder.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelFinder.Entities.Concrete
{
    public class Reservation:BaseEntity
    {
        public Customer Customer { get; set; }
        public Otel Otel { get; set; }

        private DateTime _reservationDate = DateTime.Now;
        public DateTime ReservationDate { get=>_reservationDate; set=>_reservationDate=value; }
       
    }
}
