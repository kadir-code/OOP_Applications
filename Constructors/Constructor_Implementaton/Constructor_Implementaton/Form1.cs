using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor_Implementaton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User(textBox2.Text,textBox3.Text, Convert.ToInt32(textBox4.Text),textBox5.Text);
        }
    }
}
