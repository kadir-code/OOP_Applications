using OtelFinder.Enums;
using OtelFinder.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelFinder
{
    public partial class Form1 : Form
    {
        ReservationRepository rR = new ReservationRepository();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rR.ListOtelsLocation(cmbFindLocation);
        }

        private void btnSaveCustomerInformations_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrWhiteSpace(txtCreateCustomerName.Text) || txtCreateCustomerSurname.Text == String.Empty)
            {
                lblSuccessMessage.Text = "Plaece Enter Your Informations..!";

            }
            else
            {
                lblSuccessMessage.Text = "Your Informations Saved Successfuly ..!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rR.ListOtelsName(cmbFindOtel, cmbFindLocation);
        }
        private void cmbFindOtel_SelectedIndexChanged(object sender, EventArgs e)
        {
            rR.FillReservation(cmbFindOtel,lblOtelName,lblLocation,lblPrice);
        }
    }
}
