using Abstract_Car_Example.Entities.Concrete;
using Abstract_Car_Example.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Car_Example.Repositories.Concrete
{
    public class CarRepository : BaseCarRepository
    {
        public override void CreateCar(string model, double price)
        {
            Car car = new Car();
            car.Model = model;
            car.Price = price;
            car.CreateTime = DateTime.Now;
            SeedData.cars.Add(car);
        }

        public override void DeleteCar(int id)
        {
            foreach (Car item in SeedData.cars)
            {
                if (item.Id==id)
                {
                    SeedData.cars.Remove(item);
                }
                else
                {
                    MessageBox.Show("Value Not Found..!");
                }
            }
        }

        public override List<Car> GetCars()
        {
            return SeedData.cars.ToList();
        }

        public override void UpdateCar(int id, string model, double price)
        {
            Car car = new Car();
            foreach (Car item in SeedData.cars)
            {
                if (item.Id==id)
                {
                    car.Model = model;
                    car.Price = price;
                }
                else
                {
                    MessageBox.Show("Value Not Found..!");
                }

            }
        }
    }
}
