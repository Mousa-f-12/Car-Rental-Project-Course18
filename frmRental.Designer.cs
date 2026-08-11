namespace Car_Rental_Project
{
    partial class frmRental
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFormTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlMainCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTotoalPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalCost = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDailyRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDailyRate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNumberOfDays = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumberOfDays = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbCarsNames = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblVehicleName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbCustomersNames = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCustomerName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnFilterStatus = new Guna.UI2.WinForms.Guna2Button();
            this.btnSortRentDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSortActualReturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnSortTotalPrice = new Guna.UI2.WinForms.Guna2Button();
            this.dgvRentalsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editRebtalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveRental = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelRental = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMainCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalsList)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1395, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(25, 16);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(156, 32);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Rental Contract";
            // 
            // pnlMainCard
            // 
            this.pnlMainCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlMainCard.BorderRadius = 10;
            this.pnlMainCard.BorderThickness = 1;
            this.pnlMainCard.Controls.Add(this.lbTotoalPrice);
            this.pnlMainCard.Controls.Add(this.guna2HtmlLabel1);
            this.pnlMainCard.Controls.Add(this.lblTotalCost);
            this.pnlMainCard.Controls.Add(this.txtDailyRate);
            this.pnlMainCard.Controls.Add(this.lblDailyRate);
            this.pnlMainCard.Controls.Add(this.txtNumberOfDays);
            this.pnlMainCard.Controls.Add(this.lblNumberOfDays);
            this.pnlMainCard.Controls.Add(this.cbCarsNames);
            this.pnlMainCard.Controls.Add(this.lblVehicleName);
            this.pnlMainCard.Controls.Add(this.cbCustomersNames);
            this.pnlMainCard.Controls.Add(this.lblCustomerName);
            this.pnlMainCard.FillColor = System.Drawing.Color.White;
            this.pnlMainCard.Location = new System.Drawing.Point(112, 84);
            this.pnlMainCard.Name = "pnlMainCard";
            this.pnlMainCard.Size = new System.Drawing.Size(1145, 345);
            this.pnlMainCard.TabIndex = 1;
            // 
            // lbTotoalPrice
            // 
            this.lbTotoalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbTotoalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotoalPrice.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbTotoalPrice.Location = new System.Drawing.Point(328, 260);
            this.lbTotoalPrice.Name = "lbTotoalPrice";
            this.lbTotoalPrice.Size = new System.Drawing.Size(3, 2);
            this.lbTotoalPrice.TabIndex = 11;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(6);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(188, 39);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "Add New Contract";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = false;
            this.lblTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTotalCost.Location = new System.Drawing.Point(230, 245);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(107, 52);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "Total Cost ($)";
            this.lblTotalCost.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDailyRate
            // 
            this.txtDailyRate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtDailyRate.BorderRadius = 6;
            this.txtDailyRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDailyRate.DefaultText = "";
            this.txtDailyRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtDailyRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDailyRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtDailyRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtDailyRate.Location = new System.Drawing.Point(599, 184);
            this.txtDailyRate.Name = "txtDailyRate";
            this.txtDailyRate.PlaceholderText = "0.00";
            this.txtDailyRate.ReadOnly = true;
            this.txtDailyRate.SelectedText = "";
            this.txtDailyRate.Size = new System.Drawing.Size(260, 36);
            this.txtDailyRate.TabIndex = 7;
            // 
            // lblDailyRate
            // 
            this.lblDailyRate.BackColor = System.Drawing.Color.Transparent;
            this.lblDailyRate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDailyRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblDailyRate.Location = new System.Drawing.Point(599, 161);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(82, 19);
            this.lblDailyRate.TabIndex = 6;
            this.lblDailyRate.Text = "Daily Rate ($)";
            // 
            // txtNumberOfDays
            // 
            this.txtNumberOfDays.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtNumberOfDays.BorderRadius = 6;
            this.txtNumberOfDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberOfDays.DefaultText = "";
            this.txtNumberOfDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtNumberOfDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumberOfDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtNumberOfDays.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtNumberOfDays.Location = new System.Drawing.Point(202, 184);
            this.txtNumberOfDays.Name = "txtNumberOfDays";
            this.txtNumberOfDays.PlaceholderText = "1";
            this.txtNumberOfDays.SelectedText = "";
            this.txtNumberOfDays.Size = new System.Drawing.Size(260, 36);
            this.txtNumberOfDays.TabIndex = 5;
            this.txtNumberOfDays.TextChanged += new System.EventHandler(this.txtNumberOfDays_TextChanged);
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfDays.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNumberOfDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblNumberOfDays.Location = new System.Drawing.Point(202, 161);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(104, 19);
            this.lblNumberOfDays.TabIndex = 4;
            this.lblNumberOfDays.Text = "Number Of Days";
            // 
            // cbCarsNames
            // 
            this.cbCarsNames.BackColor = System.Drawing.Color.Transparent;
            this.cbCarsNames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cbCarsNames.BorderRadius = 6;
            this.cbCarsNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCarsNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarsNames.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbCarsNames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbCarsNames.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCarsNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cbCarsNames.ItemHeight = 30;
            this.cbCarsNames.Location = new System.Drawing.Point(202, 114);
            this.cbCarsNames.Name = "cbCarsNames";
            this.cbCarsNames.Size = new System.Drawing.Size(657, 36);
            this.cbCarsNames.TabIndex = 3;
            this.cbCarsNames.SelectedIndexChanged += new System.EventHandler(this.cbCarsNames_SelectedIndexChanged);
            // 
            // lblVehicleName
            // 
            this.lblVehicleName.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblVehicleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblVehicleName.Location = new System.Drawing.Point(202, 91);
            this.lblVehicleName.Name = "lblVehicleName";
            this.lblVehicleName.Size = new System.Drawing.Size(85, 19);
            this.lblVehicleName.TabIndex = 2;
            this.lblVehicleName.Text = "Vehicle Name";
            // 
            // cbCustomersNames
            // 
            this.cbCustomersNames.BackColor = System.Drawing.Color.Transparent;
            this.cbCustomersNames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cbCustomersNames.BorderRadius = 6;
            this.cbCustomersNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCustomersNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomersNames.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbCustomersNames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbCustomersNames.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCustomersNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cbCustomersNames.ItemHeight = 30;
            this.cbCustomersNames.Location = new System.Drawing.Point(202, 44);
            this.cbCustomersNames.Name = "cbCustomersNames";
            this.cbCustomersNames.Size = new System.Drawing.Size(657, 36);
            this.cbCustomersNames.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblCustomerName.Location = new System.Drawing.Point(202, 21);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(102, 19);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnFilterStatus
            // 
            this.btnFilterStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnFilterStatus.BorderRadius = 6;
            this.btnFilterStatus.BorderThickness = 1;
            this.btnFilterStatus.FillColor = System.Drawing.Color.White;
            this.btnFilterStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnFilterStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnFilterStatus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnFilterStatus.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnFilterStatus.Location = new System.Drawing.Point(314, 447);
            this.btnFilterStatus.Name = "btnFilterStatus";
            this.btnFilterStatus.Size = new System.Drawing.Size(135, 34);
            this.btnFilterStatus.TabIndex = 5;
            this.btnFilterStatus.Text = "Status ▾";
            this.btnFilterStatus.Click += new System.EventHandler(this.btnFilterStatus_Click);
            // 
            // btnSortRentDate
            // 
            this.btnSortRentDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnSortRentDate.BorderRadius = 6;
            this.btnSortRentDate.BorderThickness = 1;
            this.btnSortRentDate.FillColor = System.Drawing.Color.White;
            this.btnSortRentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSortRentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnSortRentDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSortRentDate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnSortRentDate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSortRentDate.Location = new System.Drawing.Point(486, 447);
            this.btnSortRentDate.Name = "btnSortRentDate";
            this.btnSortRentDate.Size = new System.Drawing.Size(135, 34);
            this.btnSortRentDate.TabIndex = 6;
            this.btnSortRentDate.Text = "Rent Date ⇅";
            this.btnSortRentDate.Click += new System.EventHandler(this.btnSortRentDate_Click);
            // 
            // btnSortActualReturn
            // 
            this.btnSortActualReturn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnSortActualReturn.BorderRadius = 6;
            this.btnSortActualReturn.BorderThickness = 1;
            this.btnSortActualReturn.FillColor = System.Drawing.Color.White;
            this.btnSortActualReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSortActualReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnSortActualReturn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSortActualReturn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnSortActualReturn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSortActualReturn.Location = new System.Drawing.Point(658, 447);
            this.btnSortActualReturn.Name = "btnSortActualReturn";
            this.btnSortActualReturn.Size = new System.Drawing.Size(140, 34);
            this.btnSortActualReturn.TabIndex = 7;
            this.btnSortActualReturn.Text = "Actual Return ⇅";
            this.btnSortActualReturn.Click += new System.EventHandler(this.btnSortActualReturn_Click);
            // 
            // btnSortTotalPrice
            // 
            this.btnSortTotalPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnSortTotalPrice.BorderRadius = 6;
            this.btnSortTotalPrice.BorderThickness = 1;
            this.btnSortTotalPrice.FillColor = System.Drawing.Color.White;
            this.btnSortTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSortTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnSortTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSortTotalPrice.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnSortTotalPrice.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSortTotalPrice.Location = new System.Drawing.Point(835, 447);
            this.btnSortTotalPrice.Name = "btnSortTotalPrice";
            this.btnSortTotalPrice.Size = new System.Drawing.Size(135, 34);
            this.btnSortTotalPrice.TabIndex = 8;
            this.btnSortTotalPrice.Text = "Total Price ⇅";
            this.btnSortTotalPrice.Click += new System.EventHandler(this.btnSortTotalPrice_Click);
            // 
            // dgvRentalsList
            // 
            this.dgvRentalsList.AllowUserToAddRows = false;
            this.dgvRentalsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvRentalsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRentalsList.ColumnHeadersHeight = 35;
            this.dgvRentalsList.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentalsList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRentalsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvRentalsList.Location = new System.Drawing.Point(112, 492);
            this.dgvRentalsList.Name = "dgvRentalsList";
            this.dgvRentalsList.ReadOnly = true;
            this.dgvRentalsList.RowHeadersVisible = false;
            this.dgvRentalsList.Size = new System.Drawing.Size(1145, 290);
            this.dgvRentalsList.TabIndex = 4;
            this.dgvRentalsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvRentalsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvRentalsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dgvRentalsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRentalsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRentalsList.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvRentalsList.ThemeStyle.ReadOnly = true;
            this.dgvRentalsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvRentalsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvRentalsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvRentalsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRebtalToolStripMenuItem,
            this.deleteRentalToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(173, 56);
            // 
            // editRebtalToolStripMenuItem
            // 
            this.editRebtalToolStripMenuItem.Name = "editRebtalToolStripMenuItem";
            this.editRebtalToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.editRebtalToolStripMenuItem.Text = "Edit Rebtal";
            // 
            // deleteRentalToolStripMenuItem
            // 
            this.deleteRentalToolStripMenuItem.Name = "deleteRentalToolStripMenuItem";
            this.deleteRentalToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.deleteRentalToolStripMenuItem.Text = "Delete Rental";
            // 
            // btnSaveRental
            // 
            this.btnSaveRental.BorderRadius = 6;
            this.btnSaveRental.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveRental.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveRental.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveRental.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveRental.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSaveRental.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveRental.ForeColor = System.Drawing.Color.White;
            this.btnSaveRental.Location = new System.Drawing.Point(492, 845);
            this.btnSaveRental.Name = "btnSaveRental";
            this.btnSaveRental.Size = new System.Drawing.Size(120, 38);
            this.btnSaveRental.TabIndex = 2;
            this.btnSaveRental.Text = "Save";
            this.btnSaveRental.Click += new System.EventHandler(this.btnSaveRental_Click);
            // 
            // btnCancelRental
            // 
            this.btnCancelRental.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCancelRental.BorderRadius = 6;
            this.btnCancelRental.BorderThickness = 1;
            this.btnCancelRental.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelRental.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelRental.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelRental.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelRental.FillColor = System.Drawing.Color.White;
            this.btnCancelRental.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnCancelRental.Location = new System.Drawing.Point(702, 845);
            this.btnCancelRental.Name = "btnCancelRental";
            this.btnCancelRental.Size = new System.Drawing.Size(120, 38);
            this.btnCancelRental.TabIndex = 3;
            this.btnCancelRental.Text = "Cancel";
            // 
            // frmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1395, 896);
            this.Controls.Add(this.btnFilterStatus);
            this.Controls.Add(this.btnSortRentDate);
            this.Controls.Add(this.btnSortActualReturn);
            this.Controls.Add(this.btnSortTotalPrice);
            this.Controls.Add(this.dgvRentalsList);
            this.Controls.Add(this.btnCancelRental);
            this.Controls.Add(this.btnSaveRental);
            this.Controls.Add(this.pnlMainCard);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Contract Management";
            this.Load += new System.EventHandler(this.frmRental_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainCard.ResumeLayout(false);
            this.pnlMainCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalsList)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFormTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlMainCard;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerName;
        private Guna.UI2.WinForms.Guna2ComboBox cbCustomersNames;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVehicleName;
        private Guna.UI2.WinForms.Guna2ComboBox cbCarsNames;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfDays;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberOfDays;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDailyRate;
        private Guna.UI2.WinForms.Guna2TextBox txtDailyRate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalCost;
        private Guna.UI2.WinForms.Guna2Button btnFilterStatus;
        private Guna.UI2.WinForms.Guna2Button btnSortRentDate;
        private Guna.UI2.WinForms.Guna2Button btnSortActualReturn;
        private Guna.UI2.WinForms.Guna2Button btnSortTotalPrice;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRentalsList;
        private Guna.UI2.WinForms.Guna2Button btnSaveRental;
        private Guna.UI2.WinForms.Guna2Button btnCancelRental;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editRebtalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRentalToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTotoalPrice;
    }
}