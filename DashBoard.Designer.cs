namespace Car_Rental_Project
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCars = new Guna.UI2.WinForms.Guna2Button();
            this.btnRentals = new Guna.UI2.WinForms.Guna2Button();
            this.btnAvailableVehicles = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturnVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlSidebar.Controls.Add(this.btnCars);
            this.pnlSidebar.Controls.Add(this.btnRentals);
            this.pnlSidebar.Controls.Add(this.btnAvailableVehicles);
            this.pnlSidebar.Controls.Add(this.btnCustomers);
            this.pnlSidebar.Controls.Add(this.btnReturnVehicle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 896);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnCars
            // 
            this.btnCars.Animated = true;
            this.btnCars.BackColor = System.Drawing.Color.Transparent;
            this.btnCars.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnCars.BorderRadius = 15;
            this.btnCars.BorderThickness = 2;
            this.btnCars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCars.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCars.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCars.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCars.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCars.FillColor = System.Drawing.Color.Transparent;
            this.btnCars.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCars.ForeColor = System.Drawing.Color.White;
            this.btnCars.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnCars.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCars.Location = new System.Drawing.Point(12, 71);
            this.btnCars.Name = "btnCars";
            this.btnCars.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnCars.PressedDepth = 1;
            this.btnCars.Size = new System.Drawing.Size(226, 73);
            this.btnCars.TabIndex = 0;
            this.btnCars.Text = "Cars";
            this.btnCars.UseTransparentBackground = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // btnRentals
            // 
            this.btnRentals.Animated = true;
            this.btnRentals.BackColor = System.Drawing.Color.Transparent;
            this.btnRentals.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnRentals.BorderRadius = 15;
            this.btnRentals.BorderThickness = 2;
            this.btnRentals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRentals.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRentals.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRentals.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRentals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRentals.FillColor = System.Drawing.Color.Transparent;
            this.btnRentals.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentals.ForeColor = System.Drawing.Color.White;
            this.btnRentals.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnRentals.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRentals.Location = new System.Drawing.Point(12, 221);
            this.btnRentals.Name = "btnRentals";
            this.btnRentals.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnRentals.PressedDepth = 1;
            this.btnRentals.Size = new System.Drawing.Size(226, 73);
            this.btnRentals.TabIndex = 1;
            this.btnRentals.Text = "Rentals";
            this.btnRentals.UseTransparentBackground = true;
            this.btnRentals.Click += new System.EventHandler(this.btnRentals_Click);
            // 
            // btnAvailableVehicles
            // 
            this.btnAvailableVehicles.Animated = true;
            this.btnAvailableVehicles.BackColor = System.Drawing.Color.Transparent;
            this.btnAvailableVehicles.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnAvailableVehicles.BorderRadius = 15;
            this.btnAvailableVehicles.BorderThickness = 2;
            this.btnAvailableVehicles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvailableVehicles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAvailableVehicles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAvailableVehicles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAvailableVehicles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAvailableVehicles.FillColor = System.Drawing.Color.Transparent;
            this.btnAvailableVehicles.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailableVehicles.ForeColor = System.Drawing.Color.White;
            this.btnAvailableVehicles.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAvailableVehicles.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAvailableVehicles.Location = new System.Drawing.Point(12, 371);
            this.btnAvailableVehicles.Name = "btnAvailableVehicles";
            this.btnAvailableVehicles.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnAvailableVehicles.PressedDepth = 1;
            this.btnAvailableVehicles.Size = new System.Drawing.Size(226, 73);
            this.btnAvailableVehicles.TabIndex = 2;
            this.btnAvailableVehicles.Text = "Available";
            this.btnAvailableVehicles.UseTransparentBackground = true;
            this.btnAvailableVehicles.Click += new System.EventHandler(this.btnAvailableVehicles_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Animated = true;
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnCustomers.BorderRadius = 15;
            this.btnCustomers.BorderThickness = 2;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomers.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomers.Location = new System.Drawing.Point(12, 521);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnCustomers.PressedDepth = 1;
            this.btnCustomers.Size = new System.Drawing.Size(226, 73);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseTransparentBackground = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnReturnVehicle
            // 
            this.btnReturnVehicle.Animated = true;
            this.btnReturnVehicle.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnVehicle.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnReturnVehicle.BorderRadius = 15;
            this.btnReturnVehicle.BorderThickness = 2;
            this.btnReturnVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturnVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturnVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturnVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturnVehicle.FillColor = System.Drawing.Color.Transparent;
            this.btnReturnVehicle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnVehicle.ForeColor = System.Drawing.Color.White;
            this.btnReturnVehicle.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnReturnVehicle.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnReturnVehicle.Location = new System.Drawing.Point(12, 671);
            this.btnReturnVehicle.Name = "btnReturnVehicle";
            this.btnReturnVehicle.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnReturnVehicle.PressedDepth = 1;
            this.btnReturnVehicle.Size = new System.Drawing.Size(226, 73);
            this.btnReturnVehicle.TabIndex = 4;
            this.btnReturnVehicle.Text = "Return Car";
            this.btnReturnVehicle.UseTransparentBackground = true;
            this.btnReturnVehicle.Click += new System.EventHandler(this.btnReturnVehicle_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlContent.Size = new System.Drawing.Size(1368, 896);
            this.pnlContent.TabIndex = 1;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 896);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSidebar;
        private Guna.UI2.WinForms.Guna2Button btnCars;
        private Guna.UI2.WinForms.Guna2Button btnRentals;
        private Guna.UI2.WinForms.Guna2Button btnAvailableVehicles;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnReturnVehicle;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
    }
}