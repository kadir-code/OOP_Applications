using PayBill_Example.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayBill_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Calculate(TextBox textBox, Label label,int i)
        {
            label.Text = PaymentManagement.GetKw(Convert.ToInt32(textBox.Text) * i).ToString();
        }
       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate(txtKw,lblTotalBill,PaymentManagement.KW);
        }

        private void btnPayElectric_Click(object sender, EventArgs e)
        {
            Electric electric = new Electric();
            if (lblTotalBill.Text == txtKwUsage.Text)
            {
                MessageBox.Show($"{electric.BillName}\nPaid :{lblTotalBill.Text}\nDate :{electric.PayDate}\n");

            }
            else
            {
                MessageBox.Show($"Payment Failed...!");

            }
        }

        private void btnGasCalculate_Click(object sender, EventArgs e)
        {
            Calculate(txtGasUsage,lblGasUsage,PaymentManagement.GS);
        }

        private void btnGasPay_Click(object sender, EventArgs e)
        {
            Gas gas = new Gas();
            if (lblGasUsage.Text==txtGasPayBill.Text)
            {
                MessageBox.Show($"{gas.BillName}\nPaid :{lblGasUsage.Text}\nDate :{gas.PayDate}\n");
            }
            else
            {
                MessageBox.Show($"Payment Failed...!");

            }
        }
    }
}
