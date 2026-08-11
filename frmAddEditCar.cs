using BusinessLayer;
using System;
using System.Windows.Forms;

namespace Car_Rental_Project
{
    public partial class frmAddEditCar : Form
    {


        private clsCar _car;

        private int _carID = -1;

        private enum enMode { eAddNew, eUpdate};

        private enMode _Mode = enMode.eAddNew;

        public frmAddEditCar(int CarID)
        {
            if (CarID == -1)
                _Mode = enMode.eAddNew;
            else
            {
                _carID = CarID;
                _Mode = enMode.eUpdate;
            }
            InitializeComponent();
        }

        private void LoadData()
        {
            if(_Mode == enMode.eAddNew)
            {
                lbAddEdit.Text = "Adding New Car";
                lbID.Text = "??";
                _car = new clsCar();
                return;
            }

            lbAddEdit.Text = "Editing Car Info";

            _car = clsCar.FindCarByID(_carID);

            if(_car != null)
            {
                numYear.Maximum = DateTime.Now.Year;

                lbID.Text = _car.CarID.ToString();
                txtBrand.Text = _car.Brand;
                txtModel.Text = _car.Model;
                txtPlateNumber.Text = _car.PlateNumber;
                numYear.Value = _car.Year;
                numDailyPrice.Value = _car.DailyPrice;
            }
            else
            {
                MessageBox.Show("Vehicle Not Found");
            }
        }

        private void LoadVehcleInfo()
        {

            _car.Brand = txtBrand.Text;
            _car.Model = txtModel.Text;
            _car.PlateNumber = txtPlateNumber.Text;
            _car.Year = (int)numYear.Value;
            _car.DailyPrice = numDailyPrice.Value;
        }

        private void frmAddEditCar_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            LoadVehcleInfo();

            if (_car.Save())
            {
                MessageBox.Show("Successfuly");
                lbID.Text = _car.CarID.ToString();
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
