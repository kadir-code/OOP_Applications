using Abstract_Car_Example.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Car_Example.Repositories.Abstract
{
    public abstract class BaseCarRepository
    {
        //crud operations created
        public abstract List<Car> GetCars();
        public abstract void CreateCar(string model, double price);
        public abstract void UpdateCar(int id,string model,double price);
        public abstract void DeleteCar(int id);
    }
}
