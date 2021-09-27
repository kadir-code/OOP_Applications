using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor_MethodOverloading_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyMath myMath = new MyMath(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            MessageBox.Show($"value1+value2 :{Convert.ToInt32(textBox1.Text)+ Convert.ToInt32(textBox2.Text)}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyMath myMath = new MyMath(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            MessageBox.Show($"value1+value2*value3 :{Convert.ToInt32(textBox3.Text) + (Convert.ToInt32(textBox4.Text)* Convert.ToInt32(textBox5.Text))}");
        }
    }
}
