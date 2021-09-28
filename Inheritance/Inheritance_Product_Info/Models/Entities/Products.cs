using Inheritance_Product.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_Product.Models.Entities
{
    public class Products:CoreClass
    {
        public string Name { get; set; }
        private double _price;
        public double Price {
            get => _price;
            set
            {
                if (value<=0)
                {
                    MessageBox.Show($"Cannot enter price {value}");
                }
                else
                {
                    _price = value;

                }
            }
        }
        private int _quantity;
        public int Quantity {
            get => _quantity;
            set
            {
                if (value<=0)
                {
                    MessageBox.Show("Cannot enter quantity 0 and less");

                }
                else
                {
                    _quantity = value;
                }
            }
        }
    }
}
