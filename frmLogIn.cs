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
    public partial class frmLogIn : Form
    {

        string userName = "Admin";
        string password = "1234";

        public frmLogIn()
        {
            InitializeComponent();
        }

        private bool CheckUserNameAndPassword(string UserName, string Password)
        {
            return(this.userName == UserName && this.password == Password) ? true : false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            if (CheckUserNameAndPassword(userName,  password))
            {
                DashBoard dashBoard = new DashBoard();
                dashBoard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("UserName Or Password Is Not Valid Try Again","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
