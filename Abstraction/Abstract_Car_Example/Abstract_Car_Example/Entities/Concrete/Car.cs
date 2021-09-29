using Abstract_Car_Example.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Car_Example.Entities.Concrete
{
    public class Car : BaseEntity
    {
        //car entities created
        public override int Id { get; set; }
        public string Model { get; set; }

        private double _price;
        public double Price { get => _price; set => _price = value; }

    }
}
