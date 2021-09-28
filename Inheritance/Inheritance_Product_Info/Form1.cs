using Inheritance_Product.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Name = "machine";
            products.Price = 25.00;
            products.Quantity = 10;
            MessageBox.Show($"name :{products.Name}\n created date :{products.CreateDate}price :{products.Price}\n quantity :{products.Quantity}\n");
        }
    }
}
