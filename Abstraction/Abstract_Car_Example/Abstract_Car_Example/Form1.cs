using Abstract_Car_Example.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Car_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        //repo that contains crud methods instantiated
        CarRepository carRepository = new CarRepository();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = carRepository.GetCars();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carRepository.CreateCar(textBox1.Text,Convert.ToDouble(textBox2.Text));
            dataGridView1.DataSource = carRepository.GetCars();
           carRepository.ClearTbox(textBox1,textBox2);
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            carRepository.Find(Convert.ToInt32(txtFindId.Text),txtUpdateModel,txtUpdatePrice);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            carRepository.UpdateCar(Convert.ToInt32(txtFindId.Text),txtUpdateModel.Text,Convert.ToDouble(txtUpdatePrice.Text));
        }
    }
}
