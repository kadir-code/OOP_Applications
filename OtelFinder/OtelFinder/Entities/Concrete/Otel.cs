using OtelFinder.Entities.Abstract;
using OtelFinder.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelFinder.Entities.Concrete
{
    public class Otel: BaseEntity
    {
        public string OtelName { get; set; }
        public Locations Location { get; set; }
        public int Price { get; set; }
        public string Picture { get; set; }


    }
}
