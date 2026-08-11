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
    public partial class frmAvailableCars : Form
    {
        DataTable _availableCarsTable;
        DataView _availableCarsView;

        public frmAvailableCars()
        {
            InitializeComponent();
        }

        private void RefreshAvailableCars()
        {
            _availableCarsTable = clsCar.GetAllAvailableCars();
            _availableCarsView = _availableCarsTable.DefaultView;
        }

        private void _LoadData()
        {
            RefreshAvailableCars();
            dgvAvailableCars.DataSource = _availableCarsView;
        }

        private void frmAvailableCars_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
