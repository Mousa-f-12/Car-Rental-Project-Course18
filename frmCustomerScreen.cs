using System;
using BusinessLayer;
using System.Windows.Forms;
using System.Data;
using System.Web.UI.WebControls;

namespace Car_Rental_Project
{
    public partial class frmCustomerScreen : Form
    {
        private DataTable _customersTable;
        private DataView _customersView;
        public frmCustomerScreen()
        {
            InitializeComponent();
        }

        private void _RefershCustomersTable()
        {
            _customersTable = clsCustomer.GetAllCustomers();
             _customersView = _customersTable.DefaultView;
        }

        private void _LoadData()
        {
            _RefershCustomersTable();
            dgvCustomerList.DataSource = _customersView;
        }

        private void txtFilterByName_TextChanged(object sender, EventArgs e)
        {
            _customersView.RowFilter = $"[FullName] Like '{txtFilterByName.Text}%'";
            dgvCustomerList.DataSource = _customersView;
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            _customersView.Sort = $"[FullName] Asc";
            dgvCustomerList.DataSource = _customersView;
        }

        private void btnSortByNationalID_Click(object sender, EventArgs e)
        {
            _customersView.Sort = $"[NationalID] Asc";
            dgvCustomerList.DataSource = _customersView;
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer addCustomer = new frmAddEditCustomer(-1);
            addCustomer.ShowDialog();
            _LoadData();

        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer EditCustomer = new frmAddEditCustomer((int)dgvCustomerList.SelectedCells[0].Value);
            EditCustomer.ShowDialog();
            _LoadData();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteCustomer deleteCustomer = new frmDeleteCustomer((int)dgvCustomerList.SelectedCells[0].Value);
            deleteCustomer.ShowDialog();
      
            _LoadData();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            frmDeleteCustomer deleteCustomer = new frmDeleteCustomer();
            deleteCustomer.ShowDialog();
            _LoadData();
        }

        private void frmCustomerScreen_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
