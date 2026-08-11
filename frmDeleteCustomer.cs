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
    public partial class frmDeleteCustomer : Form
    {
        clsCustomer _customer;
        int _customerID = -1;

        public frmDeleteCustomer(int CustomerID)
        {
            _customerID = CustomerID;
            InitializeComponent();
        }

        public frmDeleteCustomer()
        {
            InitializeComponent();
        }
                private void DisplayCustomerInfo(bool IsFound)
        { 
            txtSearchID.Text        = IsFound? _customerID.ToString() : "";
            lblCustomerIDValue.Text = IsFound? _customerID.ToString() : "";
            if (IsFound == false) 
                lblFullNameValue.Text = "";
            else
                lblFullNameValue.Text = $"<div dir='rtl'>{_customer.FullName}</div>";
            lblPhoneValue.Text      = IsFound? _customer.Phone : "";
            lblNationalIDValue.Text = IsFound? _customer.Phone : "";
        }

        private void _LoadData()
        {
            _customer = clsCustomer.FindCustomerByID(_customerID);

            if (_customer != null)
            {
                _customerID = _customer.CustomerID;
                btnDelete.Enabled = true;
                DisplayCustomerInfo(true);
            }
            else
            {
                MessageBox.Show("No Customer Found");
                btnDelete.Enabled = false;
                DisplayCustomerInfo(false);
            }
        }

        private void frmDeleteCustomer_Load(object sender, EventArgs e)
        {
            if (_customerID != -1)
                _LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Delete it?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(result == DialogResult.OK)
            {
                if(clsCustomer.DeleteCustomer(_customerID))
                {
                    MessageBox.Show("Deleted Successfuly");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _customerID = Convert.ToInt32(txtSearchID.Text);
            _LoadData();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
