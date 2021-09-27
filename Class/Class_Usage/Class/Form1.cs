using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string guid= Guid.NewGuid().ToString();
            lblGuid.Text = guid;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FullName = textBox2.Text;
            user.Age = Convert.ToInt32(textBox3.Text);
            user.EMail = textBox4.Text;

            if (lblGuid.Text==textBox1.Text)
            {
                MessageBox.Show("User Registered..!");
            }
            else
            {
                MessageBox.Show("User Failed To Registered..!");

            }
        }
    }
}
