namespace Car_Rental_Project
{
    partial class frmReturnCar
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFormTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlMainCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblVehicleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbVehicleName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCustomerLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbCustomerName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblReturnDateHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pbCheckMark1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbCheckMark2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSaveReturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelReturn = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMainCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMark1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMark2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(620, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(25, 16);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(147, 32);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Return Vehicle";
            // 
            // pnlMainCard
            // 
            this.pnlMainCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlMainCard.BorderRadius = 10;
            this.pnlMainCard.BorderThickness = 1;
            this.pnlMainCard.Controls.Add(this.lblVehicleLabel);
            this.pnlMainCard.Controls.Add(this.lbVehicleName);
            this.pnlMainCard.Controls.Add(this.lblCustomerLabel);
            this.pnlMainCard.Controls.Add(this.lbCustomerName);
            this.pnlMainCard.Controls.Add(this.lblReturnDateHeader);
            this.pnlMainCard.Controls.Add(this.guna2DateTimePicker1);
            this.pnlMainCard.Controls.Add(this.pbCheckMark1);
            this.pnlMainCard.Controls.Add(this.guna2HtmlLabel4);
            this.pnlMainCard.Controls.Add(this.pbCheckMark2);
            this.pnlMainCard.Controls.Add(this.guna2HtmlLabel5);
            this.pnlMainCard.FillColor = System.Drawing.Color.White;
            this.pnlMainCard.Location = new System.Drawing.Point(25, 85);
            this.pnlMainCard.Name = "pnlMainCard";
            this.pnlMainCard.Size = new System.Drawing.Size(570, 335);
            this.pnlMainCard.TabIndex = 1;
            // 
            // lblVehicleLabel
            // 
            this.lblVehicleLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblVehicleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblVehicleLabel.Location = new System.Drawing.Point(20, 20);
            this.lblVehicleLabel.Name = "lblVehicleLabel";
            this.lblVehicleLabel.Size = new System.Drawing.Size(48, 19);
            this.lblVehicleLabel.TabIndex = 0;
            this.lblVehicleLabel.Text = "Vehicle:";
            // 
            // lbVehicleName
            // 
            this.lbVehicleName.BackColor = System.Drawing.Color.Transparent;
            this.lbVehicleName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lbVehicleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lbVehicleName.Location = new System.Drawing.Point(77, 19);
            this.lbVehicleName.Name = "lbVehicleName";
            this.lbVehicleName.Size = new System.Drawing.Size(95, 21);
            this.lbVehicleName.TabIndex = 1;
            this.lbVehicleName.Text = "Vehicle Name";
            // 
            // lblCustomerLabel
            // 
            this.lblCustomerLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCustomerLabel.Location = new System.Drawing.Point(290, 20);
            this.lblCustomerLabel.Name = "lblCustomerLabel";
            this.lblCustomerLabel.Size = new System.Drawing.Size(65, 19);
            this.lblCustomerLabel.TabIndex = 2;
            this.lblCustomerLabel.Text = "Customer:";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lbCustomerName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lbCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lbCustomerName.Location = new System.Drawing.Point(363, 19);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(111, 21);
            this.lbCustomerName.TabIndex = 3;
            this.lbCustomerName.Text = "Customer Name";
            // 
            // lblReturnDateHeader
            // 
            this.lblReturnDateHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnDateHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblReturnDateHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblReturnDateHeader.Location = new System.Drawing.Point(20, 109);
            this.lblReturnDateHeader.Name = "lblReturnDateHeader";
            this.lblReturnDateHeader.Size = new System.Drawing.Size(196, 19);
            this.lblReturnDateHeader.TabIndex = 4;
            this.lblReturnDateHeader.Text = "Set Actual Return Date && Time";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.guna2DateTimePicker1.BorderRadius = 6;
            this.guna2DateTimePicker1.BorderThickness = 1;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(20, 156);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(530, 38);
            this.guna2DateTimePicker1.TabIndex = 5;
            this.guna2DateTimePicker1.Value = new System.DateTime(2026, 8, 2, 16, 5, 42, 574);
            // 
            // pbCheckMark1
            // 
            this.pbCheckMark1.BackColor = System.Drawing.Color.Transparent;
            this.pbCheckMark1.Image = global::Car_Rental_Project.Properties.Resources.checkmark;
            this.pbCheckMark1.ImageRotate = 0F;
            this.pbCheckMark1.Location = new System.Drawing.Point(20, 228);
            this.pbCheckMark1.Name = "pbCheckMark1";
            this.pbCheckMark1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbCheckMark1.Size = new System.Drawing.Size(22, 22);
            this.pbCheckMark1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCheckMark1.TabIndex = 6;
            this.pbCheckMark1.TabStop = false;
            this.pbCheckMark1.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(50, 222);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(192, 19);
            this.guna2HtmlLabel4.TabIndex = 7;
            this.guna2HtmlLabel4.Text = "Car with ID 43 Is Available Now";
            // 
            // pbCheckMark2
            // 
            this.pbCheckMark2.BackColor = System.Drawing.Color.Transparent;
            this.pbCheckMark2.Image = global::Car_Rental_Project.Properties.Resources.checkmark;
            this.pbCheckMark2.ImageRotate = 0F;
            this.pbCheckMark2.Location = new System.Drawing.Point(20, 268);
            this.pbCheckMark2.Name = "pbCheckMark2";
            this.pbCheckMark2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbCheckMark2.Size = new System.Drawing.Size(22, 22);
            this.pbCheckMark2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCheckMark2.TabIndex = 8;
            this.pbCheckMark2.TabStop = false;
            this.pbCheckMark2.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(50, 269);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(256, 19);
            this.guna2HtmlLabel5.TabIndex = 9;
            this.guna2HtmlLabel5.Text = "Rental status with ID 114 Is Returned Now";
            // 
            // btnSaveReturn
            // 
            this.btnSaveReturn.BorderRadius = 6;
            this.btnSaveReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveReturn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSaveReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveReturn.ForeColor = System.Drawing.Color.White;
            this.btnSaveReturn.Location = new System.Drawing.Point(345, 439);
            this.btnSaveReturn.Name = "btnSaveReturn";
            this.btnSaveReturn.Size = new System.Drawing.Size(120, 38);
            this.btnSaveReturn.TabIndex = 2;
            this.btnSaveReturn.Text = "Save";
            // 
            // btnCancelReturn
            // 
            this.btnCancelReturn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCancelReturn.BorderRadius = 6;
            this.btnCancelReturn.BorderThickness = 1;
            this.btnCancelReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelReturn.FillColor = System.Drawing.Color.White;
            this.btnCancelReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnCancelReturn.Location = new System.Drawing.Point(475, 439);
            this.btnCancelReturn.Name = "btnCancelReturn";
            this.btnCancelReturn.Size = new System.Drawing.Size(120, 38);
            this.btnCancelReturn.TabIndex = 3;
            this.btnCancelReturn.Text = "Cancel";
            // 
            // frmReturnCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(620, 542);
            this.Controls.Add(this.btnCancelReturn);
            this.Controls.Add(this.btnSaveReturn);
            this.Controls.Add(this.pnlMainCard);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReturnCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Vehicle Management";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainCard.ResumeLayout(false);
            this.pnlMainCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMark1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckMark2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFormTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlMainCard;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVehicleLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbVehicleName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbCustomerName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReturnDateHeader;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbCheckMark1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbCheckMark2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btnSaveReturn;
        private Guna.UI2.WinForms.Guna2Button btnCancelReturn;
    }
}