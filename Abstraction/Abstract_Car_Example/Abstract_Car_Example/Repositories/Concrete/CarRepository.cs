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
        public override void ClearTbox(TextBox tbx, TextBox tbx2)
        {
            tbx.Text = String.Empty;
            tbx2.Text = String.Empty;
        }

        public override void CreateCar(string model, double price)
        {
            Car car = new Car(5, model, price);
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

        public override void Find(int id, TextBox tbxModel, TextBox tbxPrice)
        {
            foreach (Car item in SeedData.cars)
            {
                if (item.Id==id)
                {
                    tbxModel.Text = item.Model;
                    tbxPrice.Text = item.Price.ToString();
                }
            }
        }

        public override List<Car> GetCars()
        {
            return SeedData.cars.ToList();
        }

        public override void UpdateCar(int id, string model, double price)
        {
            Car car = new Car(5, model, price);
            foreach (Car item in SeedData.cars)
            {
                if (item.Id==id)
                {
                    item.Model = model;
                    item.Price = price;
                }

            }
        }
    }
}
