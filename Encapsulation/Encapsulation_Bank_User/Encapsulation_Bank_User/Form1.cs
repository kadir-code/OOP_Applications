using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation_Bank_User
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        User user = new User();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            user.UserName = textBox1.Text;
            user.Balance = Convert.ToInt32(textBox2.Text);
            lblGuid.Text = user.Id.ToString();
            lblCreateDate.Text = user.CreateTime.ToString();
            lblUserName.Text = user.UserName;
            lblBalance.Text = Convert.ToString(user.Balance);
        }
    }
}
