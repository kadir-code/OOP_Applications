using OtelFinder.Entities.Concrete;
using OtelFinder.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelFinder.Repositories.Abstract
{
    public abstract class BaseReservationRepository 
    {
        public abstract void DeleteOtel(int id);
        public abstract void CreateReservation(int id,Customer customer,Otel otel);
    }
}
