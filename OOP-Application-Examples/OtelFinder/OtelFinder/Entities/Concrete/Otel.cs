using OtelFinder.Entities.Abstract;
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
        public Enum Location { get; set; }
        public int Price { get; set; }
        public string Picture { get; set; }
        public override string ToString()
        {
            return this.Location.ToString();
        }

    }
}
