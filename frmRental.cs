using System;
using System.CodeDom;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;

namespace Car_Rental_Project
{
    public partial class frmRental : Form
    {
        DataTable _rentalsTable;
        DataTable _customersTable;
        DataTable _carsTable;
        DataView _rentalsView;
        clsRental _rental;
        decimal _dailyPrice;

        public frmRental()
        {
            InitializeComponent();
        }

        private void _RefershRentalsList()
        {
            _rentalsTable = clsRental.GetAllRentals();
            _rentalsView = _rentalsTable.DefaultView;
        }
            
        private void _LoadLookups()
        {
            _customersTable = clsCustomer.GetAllCustomers();
            _carsTable = clsCar.GetAllVehicles();
        }

        private void FillCustomerNameAndCarName()
        {
            cbCustomersNames.DataSource = _customersTable;
            cbCustomersNames.DisplayMember = "FullName";
            cbCustomersNames.ValueMember = "CustomerID";

            if (!_carsTable.Columns.Contains("CarName"))
                _carsTable.Columns.Add("CarName", typeof(string), "Brand + ' ' + Model");

            cbCarsNames.DataSource = _carsTable;    
            cbCarsNames.DisplayMember = "CarName";
            cbCarsNames.ValueMember = "CarID";

        }

        private void _LoadData()
        {
            _RefershRentalsList();

            _LoadLookups();

            dgvRentalsList.DataSource = _rentalsView;

            FillCustomerNameAndCarName();
        }

        private void btnSortTotalPrice_Click(object sender, EventArgs e)
        {
            _rentalsView.Sort = "TotalPrice DESC";
        }

        private void btnSortActualReturn_Click(object sender, EventArgs e)
        {
            _rentalsView.Sort = "ActualReturnDate DESC";

        }

        private void btnSortRentDate_Click(object sender, EventArgs e)
        {
            _rentalsView.Sort = "RentDate DESC";
        }

        private void btnFilterStatus_Click(object sender, EventArgs e)
        {
            _rentalsView.Sort = "Status DESC";
        }   

        private void frmRental_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private decimal CalaculateTotalPrice(decimal DailyPrice)
        {
            decimal retnalDays = Convert.ToDecimal(txtNumberOfDays.Text);
            return DailyPrice * retnalDays;
        }

        private decimal CalculateDailyPrice()
        {
             int CarID = Convert.ToInt32(cbCarsNames.SelectedValue);

             decimal DailyPrice = 0;

             foreach (DataRow row in _carsTable.Rows)
             {
                 if ((int)row["CarID"] == CarID)
                 {
                    DailyPrice = (decimal)row["DailyPrice"];
                    break;
                 }
             }
            return DailyPrice;
         }

        private void cbCarsNames_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbCarsNames.SelectedIndex != -1)
            {
                if (cbCarsNames.SelectedValue is DataRowView)
                    return;
                _dailyPrice = CalculateDailyPrice();

                txtDailyRate.Text = _dailyPrice.ToString("0.00");
             }
         }

        private void txtNumberOfDays_TextChanged(object sender, EventArgs e)
        {
            lblTotalCost.ForeColor = Color.Teal;
            if (int.TryParse(txtNumberOfDays.Text, out int NnumberofDays))
            {               
                decimal totalPrice = CalaculateTotalPrice(_dailyPrice);
                lblTotalCost.Text = totalPrice.ToString("0.00") + "$";
                return;
            }
            lblTotalCost.Text = "0$";

        }

        private  void FillRentalInformation()
        {
            _rental = new clsRental();
            _rental.CustomerID = Convert.ToInt32(cbCustomersNames.SelectedValue);
            _rental.CarID = Convert.ToInt32(cbCarsNames.SelectedValue);
            _rental.TotalPrice = Convert.ToDecimal(lblTotalCost.Text.Replace("$", ""));
            _rental.Status = "Active";
            _rental.RentDate = DateTime.Now.Date;
            _rental.ActualReturnDate = DateTime.MinValue;
            _rental.ExpectedReturnDate = DateTime.Now.Date.AddDays(Convert.ToInt32(txtNumberOfDays.Text));
        }


        private void btnSaveRental_Click(object sender, EventArgs e)
        {

            FillRentalInformation();

           if(_rental.Save())
            {
                MessageBox.Show("Saved");
                _RefershRentalsList();
                dgvRentalsList.DataSource = _rentalsView;
            }

        }
    }
}
