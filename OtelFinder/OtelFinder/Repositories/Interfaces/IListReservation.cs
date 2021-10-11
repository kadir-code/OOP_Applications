using OtelFinder.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelFinder.Repositories.Interfaces
{
    public interface IListReservation
    {
        List<Reservation> ListReservations();
    }
}
