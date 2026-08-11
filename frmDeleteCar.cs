using BusinessLayer;
using System;
using System.Windows.Forms;

namespace Car_Rental_Project
{
    public partial class frmDeleteCar : Form
    {
        clsCar _car;
        int _carID = -1;

        public frmDeleteCar(int CarID)
        {
           _carID = CarID;
           InitializeComponent();
        }

        public frmDeleteCar()
        {
            InitializeComponent();
        }

        private void DisplayDataOnScreen(bool Found)
        {
            if(Found)
            {
                txtSearchID.Text = _car.CarID.ToString();
                lblBrandValue.Text = _car.Brand;
                lblModelValue.Text = _car.Model;
                lblPlateValue.Text = _car.PlateNumber;
                lblYearPriceValue.Text = _car.Year.ToString() + " / " + _car.DailyPrice.ToString();
                btnDelete.Enabled = true;
            }
            else
            {
                lblBrandValue.Text = "";
                lblModelValue.Text = "";
                lblPlateValue.Text = "";
                lblYearPriceValue.Text = "";
                btnDelete.Enabled = false;
            }
        }

        private void _LoadData(int CarID)
        {
                _car = clsCar.FindCarByID(CarID);

                if (_car != null)
                {
                    DisplayDataOnScreen(true);
                }
                else
                {
                    MessageBox.Show("Vehicle Is Not Exists");
                    DisplayDataOnScreen(false);
                } 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _carID = Convert.ToInt32(txtSearchID.Text);
            _LoadData(_carID);
        }

        private void frmDeleteCar_Load(object sender, EventArgs e)
        {
            if (_carID != -1)
                _LoadData(_carID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Delete it?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(result == DialogResult.OK)
            {
                clsCar.DeleteVehicle(_carID);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
