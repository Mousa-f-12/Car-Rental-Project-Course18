using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Project
{
    public partial class frmCars : Form
    {

        private DataTable _vehicleTable;

        private DataView _viewVehicleTable;

        public frmCars()
        {
            InitializeComponent();
        }

        public DataView RefershVehiclesList()
        {
            _vehicleTable = clsCar.GetAllVehicles();
           return _viewVehicleTable = _vehicleTable.DefaultView;
        }

        private void LoadCbFilterOptions()
        {
            string Brand = "";
            string Model = "";
            string Year  = "";

            foreach (DataRow row in _vehicleTable.Rows)
            {
                Brand = (string)row["Brand"];
                Model = (string)row["Model"];
                Year  = (string)row["Year"].ToString();

                if (!cbFilterByVehicleBrand.Items.Contains(Brand))
                    cbFilterByVehicleBrand.Items.Add(Brand);

                if (!cbFilterByModel.Items.Contains(Model))
                    cbFilterByModel.Items.Add(Model);

                if (!cbFilterByVehicleYear.Items.Contains(Year))
                    cbFilterByVehicleYear.Items.Add(Year);
            } 
        }

        private void _LoadData()
        {
            dgvCarsList.DataSource = RefershVehiclesList();
            LoadCbFilterOptions();
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            frmAddEditCar addEdit = new frmAddEditCar(-1);

            addEdit.ShowDialog();
            dgvCarsList.DataSource = RefershVehiclesList();
        }

        private void cbFilterByVehicleYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((cbFilterByVehicleYear.Text == "Year"))
            {
                _viewVehicleTable.RowFilter = "";
            }
            else
            {
                _viewVehicleTable.RowFilter = $"Year = '{cbFilterByVehicleYear.Text}'";
            }

            dgvCarsList.DataSource = _viewVehicleTable;
        }

        private void cbFilterByVehicleBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbFilterByVehicleBrand.Text == "Brand"))
            {
                _viewVehicleTable.RowFilter = "";
            }
            else
            {
                _viewVehicleTable.RowFilter = $"Brand = '{cbFilterByVehicleBrand.Text}'";
            }

            dgvCarsList.DataSource = _viewVehicleTable;
        }

        private void cbFilterByModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbFilterByModel.Text == "Model"))
            {
                _viewVehicleTable.RowFilter = "";
            }
            else
            {
                _viewVehicleTable.RowFilter = $"Model = '{cbFilterByModel.Text}'";
            }

            dgvCarsList.DataSource = _viewVehicleTable;
        }

        private void txtFilterByVehicleBrand_TextChanged(object sender, EventArgs e)
        {
            _viewVehicleTable.RowFilter = $"Brand LIKE  '%{txtFilterByVehicleBrand.Text}%'";
            dgvCarsList.DataSource = _viewVehicleTable;
        }

        private void editCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCar addEdit = new frmAddEditCar((int)dgvCarsList.SelectedCells[0].Value);
            addEdit.ShowDialog();

            dgvCarsList.DataSource = RefershVehiclesList();
        }

        private void deleteCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CarID = (int)dgvCarsList.SelectedCells[0].Value;

            frmDeleteCar deleteCar = new frmDeleteCar(CarID);
            deleteCar.ShowDialog(); 

            dgvCarsList.DataSource = RefershVehiclesList();
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            frmDeleteCar deleteCar = new frmDeleteCar();
            deleteCar.ShowDialog();

            dgvCarsList.DataSource = RefershVehiclesList();
        }
    }
}
