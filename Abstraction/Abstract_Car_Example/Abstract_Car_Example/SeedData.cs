using Abstract_Car_Example.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Car_Example
{
    public static class SeedData
    {
        public static List<Car> cars = new List<Car>()
        {
            new Car{Id=1,Model="bmw",Price=250.00,},
            new Car{Id=2,Model="seat",Price=350.00},
            new Car{Id=3,Model="fiat",Price=450.00},
            new Car{Id=4,Model="xpr",Price=610.00},
        };
    }
}
