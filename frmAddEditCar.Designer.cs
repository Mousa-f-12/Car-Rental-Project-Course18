namespace Car_Rental_Project
{
    partial class frmAddEditCar
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
            this.lbAddEdit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlMainCard = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblModel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPlateNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPlateNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numYear = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numDailyPrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMainCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lbAddEdit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(600, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lbAddEdit
            // 
            this.lbAddEdit.BackColor = System.Drawing.Color.Transparent;
            this.lbAddEdit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbAddEdit.ForeColor = System.Drawing.Color.White;
            this.lbAddEdit.Location = new System.Drawing.Point(25, 16);
            this.lbAddEdit.Name = "lbAddEdit";
            this.lbAddEdit.Size = new System.Drawing.Size(175, 32);
            this.lbAddEdit.TabIndex = 0;
            this.lbAddEdit.Text = "Add New Vehicle";
            // 
            // pnlMainCard
            // 
            this.pnlMainCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlMainCard.BorderRadius = 10;
            this.pnlMainCard.BorderThickness = 1;
            this.pnlMainCard.Controls.Add(this.guna2HtmlLabel1);
            this.pnlMainCard.Controls.Add(this.lbID);
            this.pnlMainCard.Controls.Add(this.lblBrand);
            this.pnlMainCard.Controls.Add(this.txtBrand);
            this.pnlMainCard.Controls.Add(this.lblModel);
            this.pnlMainCard.Controls.Add(this.txtModel);
            this.pnlMainCard.Controls.Add(this.lblPlateNumber);
            this.pnlMainCard.Controls.Add(this.txtPlateNumber);
            this.pnlMainCard.Controls.Add(this.guna2HtmlLabel2);
            this.pnlMainCard.Controls.Add(this.numYear);
            this.pnlMainCard.Controls.Add(this.guna2HtmlLabel3);
            this.pnlMainCard.Controls.Add(this.numDailyPrice);
            this.pnlMainCard.FillColor = System.Drawing.Color.White;
            this.pnlMainCard.Location = new System.Drawing.Point(25, 85);
            this.pnlMainCard.Name = "pnlMainCard";
            this.pnlMainCard.Size = new System.Drawing.Size(550, 360);
            this.pnlMainCard.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(25, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(65, 19);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Vehicle ID:";
            // 
            // lbID
            // 
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lbID.Location = new System.Drawing.Point(100, 19);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(28, 19);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "N/A";
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblBrand.Location = new System.Drawing.Point(25, 55);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(39, 19);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtBrand.BorderRadius = 6;
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.DefaultText = "";
            this.txtBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtBrand.Location = new System.Drawing.Point(25, 77);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(0);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.PlaceholderText = "e.g. Toyota";
            this.txtBrand.SelectedText = "";
            this.txtBrand.Size = new System.Drawing.Size(500, 36);
            this.txtBrand.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.BackColor = System.Drawing.Color.Transparent;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblModel.Location = new System.Drawing.Point(25, 125);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(42, 19);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtModel.BorderRadius = 6;
            this.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModel.DefaultText = "";
            this.txtModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtModel.Location = new System.Drawing.Point(25, 147);
            this.txtModel.Margin = new System.Windows.Forms.Padding(0);
            this.txtModel.Name = "txtModel";
            this.txtModel.PlaceholderText = "e.g. Camry";
            this.txtModel.SelectedText = "";
            this.txtModel.Size = new System.Drawing.Size(500, 36);
            this.txtModel.TabIndex = 5;
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPlateNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPlateNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPlateNumber.Location = new System.Drawing.Point(25, 195);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(86, 19);
            this.lblPlateNumber.TabIndex = 6;
            this.lblPlateNumber.Text = "Plate Number";
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtPlateNumber.BorderRadius = 6;
            this.txtPlateNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlateNumber.DefaultText = "";
            this.txtPlateNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtPlateNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlateNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPlateNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtPlateNumber.Location = new System.Drawing.Point(25, 217);
            this.txtPlateNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.PlaceholderText = "e.g. ABC-1234";
            this.txtPlateNumber.SelectedText = "";
            this.txtPlateNumber.Size = new System.Drawing.Size(500, 36);
            this.txtPlateNumber.TabIndex = 7;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(25, 265);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(30, 19);
            this.guna2HtmlLabel2.TabIndex = 8;
            this.guna2HtmlLabel2.Text = "Year";
            // 
            // numYear
            // 
            this.numYear.BackColor = System.Drawing.Color.Transparent;
            this.numYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.numYear.BorderRadius = 6;
            this.numYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.numYear.Location = new System.Drawing.Point(25, 287);
            this.numYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(235, 36);
            this.numYear.TabIndex = 9;
            this.numYear.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.numYear.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.numYear.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(290, 265);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(83, 19);
            this.guna2HtmlLabel3.TabIndex = 10;
            this.guna2HtmlLabel3.Text = "Daily Rate ($)";
            // 
            // numDailyPrice
            // 
            this.numDailyPrice.BackColor = System.Drawing.Color.Transparent;
            this.numDailyPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.numDailyPrice.BorderRadius = 6;
            this.numDailyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numDailyPrice.DecimalPlaces = 2;
            this.numDailyPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numDailyPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.numDailyPrice.Location = new System.Drawing.Point(290, 287);
            this.numDailyPrice.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numDailyPrice.Name = "numDailyPrice";
            this.numDailyPrice.Size = new System.Drawing.Size(235, 36);
            this.numDailyPrice.TabIndex = 11;
            this.numDailyPrice.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.numDailyPrice.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 6;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(325, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 38);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCancel.BorderRadius = 6;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnCancel.Location = new System.Drawing.Point(455, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(600, 525);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlMainCard);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddEditCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Management";
            this.Load += new System.EventHandler(this.frmAddEditCar_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainCard.ResumeLayout(false);
            this.pnlMainCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbAddEdit;
        private Guna.UI2.WinForms.Guna2Panel pnlMainCard;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBrand;
        private Guna.UI2.WinForms.Guna2TextBox txtBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModel;
        private Guna.UI2.WinForms.Guna2TextBox txtModel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPlateNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtPlateNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2NumericUpDown numYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2NumericUpDown numDailyPrice;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}