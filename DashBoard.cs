using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Project
{
    public partial class DashBoard : Form
    {


        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            frmCars carForm = new frmCars();

            carForm.Dock = DockStyle.Fill;

            carForm.FormBorderStyle = FormBorderStyle.None;

            carForm.TopLevel = false;

            pnlContent.Controls.Clear();

            pnlContent.Controls.Add(carForm);

            carForm.Show();


        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

            frmCustomerScreen customerFrom = new frmCustomerScreen();

            pnlContent.Controls.Clear();

            customerFrom.Dock = DockStyle.Fill;

            customerFrom.FormBorderStyle = FormBorderStyle.None;

            customerFrom.TopLevel = false;

            pnlContent.Controls.Add(customerFrom);

            customerFrom.Show();

            
        }

        private void btnReturnVehicle_Click(object sender, EventArgs e)
        {
            frmReturnCar returnCar = new frmReturnCar();

            pnlContent.Controls.Clear();

            returnCar.Dock = DockStyle.Fill;

            returnCar.FormBorderStyle = FormBorderStyle.None;

            returnCar.TopLevel = false;

            pnlContent.Controls.Add(returnCar);

            returnCar.Show();
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {

            frmRental rentalFrom = new frmRental();

            pnlContent.Controls.Clear();

            rentalFrom.Dock = DockStyle.Fill;

            rentalFrom.FormBorderStyle = FormBorderStyle.None;

            rentalFrom.TopLevel = false;

            pnlContent.Controls.Add(rentalFrom);

            rentalFrom.Show();
        }

        private void btnAvailableVehicles_Click(object sender, EventArgs e)
        {
            frmAvailableCars frmAvailable = new frmAvailableCars();

            pnlContent.Controls.Clear();

            frmAvailable.Dock = DockStyle.Fill;

            frmAvailable.FormBorderStyle = FormBorderStyle.None;

            frmAvailable.TopLevel = false;

            pnlContent.Controls.Add(frmAvailable);

            frmAvailable.Show();
        }
    }
}
