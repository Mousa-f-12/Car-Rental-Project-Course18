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
    public partial class frmAddEditCustomer : Form
    {
        private clsCustomer _customer;

        private int _customerID = -1;

        private enum enMode { eAddNew, eUpdate };

        private enMode _Mode = enMode.eAddNew;

        public frmAddEditCustomer(int CustomerID)
        {
            _customerID = CustomerID;
            _Mode = (_customerID == -1) ? enMode.eAddNew : enMode.eUpdate;

            InitializeComponent();
        }

        private void _LoadData()
        {
            if (_Mode == enMode.eAddNew)
            {
                lblCustomerIDValue.Text = "Adding New Customer";
                _customer = new clsCustomer();
                return;
            }

            _customer = clsCustomer.FindCustomerByID(_customerID);

            if (_customer != null)
            {
                lblCustomerIDValue.Text = _customer.CustomerID.ToString();
                txtFullName.Text = _customer.FullName;
                txtPhone.Text = _customer.Phone;
                txtNationalID.Text = _customer.NationalID;
            }
        }

        private void _FillCustomerObject()
        {
            _customer.FullName = txtFullName.Text;
            _customer.Phone = txtPhone.Text;
            _customer.NationalID = txtNationalID.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillCustomerObject();

            if (_customer.Save())
            {
                MessageBox.Show("Saved Successfuly", "", MessageBoxButtons.OK  ,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Something Went Wrong", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
