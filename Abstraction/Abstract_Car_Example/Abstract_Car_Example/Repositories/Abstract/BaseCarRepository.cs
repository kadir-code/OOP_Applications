using Abstract_Car_Example.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Car_Example.Repositories.Abstract
{
    public abstract class BaseCarRepository
    {
        //crud operations created
        public abstract List<Car> GetCars();
        public abstract void CreateCar(string model, double price);
        public abstract void UpdateCar(int id,string model,double price);
        public abstract void DeleteCar(int id);
        public abstract void Find(int id,TextBox tbxModel,TextBox tbxPrice);
        public abstract void ClearTbox(TextBox tbx, TextBox tbx2);
    }
}
