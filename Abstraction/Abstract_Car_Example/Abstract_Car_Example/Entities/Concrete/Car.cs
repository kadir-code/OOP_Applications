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
        public string Model { get; set; }

        private double _price;
        public double Price { get => _price; set => _price = value; }

        public Car()
        {

        }

        public Car(int id, string model, double price)
        {
            this.Id = id;
            this.Model = model;
            this.Price = price;

        }
    }
}
