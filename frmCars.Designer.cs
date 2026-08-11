namespace Car_Rental_Project
{
    partial class frmCars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDeleteVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddNewVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddNewCar = new Guna.UI2.WinForms.Guna2Button();
            this.cbFilterByVehicleYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilterByVehicleBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilterByModel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilterByVehicleBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvCarsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsList)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.btnAddNewCar);
            this.guna2Panel1.Controls.Add(this.cbFilterByVehicleYear);
            this.guna2Panel1.Controls.Add(this.cbFilterByVehicleBrand);
            this.guna2Panel1.Controls.Add(this.cbFilterByModel);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1339, 453);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.btnDeleteVehicle);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Controls.Add(this.btnAddNewVehicle);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1339, 150);
            this.guna2Panel2.TabIndex = 2;
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Animated = true;
            this.btnDeleteVehicle.BorderRadius = 10;
            this.btnDeleteVehicle.FillColor = System.Drawing.Color.Red;
            this.btnDeleteVehicle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteVehicle.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVehicle.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnDeleteVehicle.Location = new System.Drawing.Point(305, 70);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(190, 50);
            this.btnDeleteVehicle.TabIndex = 2;
            this.btnDeleteVehicle.Text = "- Delete Vehicle";
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(185, 42);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Quick Actions";
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.Animated = true;
            this.btnAddNewVehicle.BorderRadius = 10;
            this.btnAddNewVehicle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddNewVehicle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewVehicle.ForeColor = System.Drawing.Color.White;
            this.btnAddNewVehicle.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAddNewVehicle.Location = new System.Drawing.Point(12, 70);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.Size = new System.Drawing.Size(190, 50);
            this.btnAddNewVehicle.TabIndex = 0;
            this.btnAddNewVehicle.Text = "+ Add New Vehicle";
            this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(185, 42);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Quick Actions";
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Animated = true;
            this.btnAddNewCar.BorderRadius = 10;
            this.btnAddNewCar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddNewCar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewCar.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCar.Location = new System.Drawing.Point(12, 70);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(190, 50);
            this.btnAddNewCar.TabIndex = 0;
            this.btnAddNewCar.Text = "+ Add New Car";
            // 
            // cbFilterByVehicleYear
            // 
            this.cbFilterByVehicleYear.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterByVehicleYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cbFilterByVehicleYear.BorderRadius = 8;
            this.cbFilterByVehicleYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterByVehicleYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByVehicleYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbFilterByVehicleYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbFilterByVehicleYear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbFilterByVehicleYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cbFilterByVehicleYear.ItemHeight = 30;
            this.cbFilterByVehicleYear.Items.AddRange(new object[] {
            "Year"});
            this.cbFilterByVehicleYear.Location = new System.Drawing.Point(533, 386);
            this.cbFilterByVehicleYear.Name = "cbFilterByVehicleYear";
            this.cbFilterByVehicleYear.Size = new System.Drawing.Size(232, 36);
            this.cbFilterByVehicleYear.StartIndex = 0;
            this.cbFilterByVehicleYear.TabIndex = 6;
            this.cbFilterByVehicleYear.SelectedIndexChanged += new System.EventHandler(this.cbFilterByVehicleYear_SelectedIndexChanged);
            // 
            // cbFilterByVehicleBrand
            // 
            this.cbFilterByVehicleBrand.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterByVehicleBrand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cbFilterByVehicleBrand.BorderRadius = 8;
            this.cbFilterByVehicleBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterByVehicleBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByVehicleBrand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbFilterByVehicleBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbFilterByVehicleBrand.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbFilterByVehicleBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cbFilterByVehicleBrand.ItemHeight = 30;
            this.cbFilterByVehicleBrand.Items.AddRange(new object[] {
            "Brand"});
            this.cbFilterByVehicleBrand.Location = new System.Drawing.Point(932, 386);
            this.cbFilterByVehicleBrand.Name = "cbFilterByVehicleBrand";
            this.cbFilterByVehicleBrand.Size = new System.Drawing.Size(225, 36);
            this.cbFilterByVehicleBrand.StartIndex = 0;
            this.cbFilterByVehicleBrand.TabIndex = 7;
            this.cbFilterByVehicleBrand.SelectedIndexChanged += new System.EventHandler(this.cbFilterByVehicleBrand_SelectedIndexChanged);
            // 
            // cbFilterByModel
            // 
            this.cbFilterByModel.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterByModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cbFilterByModel.BorderRadius = 8;
            this.cbFilterByModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterByModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByModel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbFilterByModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbFilterByModel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbFilterByModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cbFilterByModel.ItemHeight = 30;
            this.cbFilterByModel.Items.AddRange(new object[] {
            "Model"});
            this.cbFilterByModel.Location = new System.Drawing.Point(124, 386);
            this.cbFilterByModel.Name = "cbFilterByModel";
            this.cbFilterByModel.Size = new System.Drawing.Size(242, 36);
            this.cbFilterByModel.StartIndex = 0;
            this.cbFilterByModel.TabIndex = 5;
            this.cbFilterByModel.SelectedIndexChanged += new System.EventHandler(this.cbFilterByModel_SelectedIndexChanged);
            // 
            // txtFilterByVehicleBrand
            // 
            this.txtFilterByVehicleBrand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtFilterByVehicleBrand.BorderRadius = 10;
            this.txtFilterByVehicleBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterByVehicleBrand.DefaultText = "";
            this.txtFilterByVehicleBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtFilterByVehicleBrand.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFilterByVehicleBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtFilterByVehicleBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtFilterByVehicleBrand.Location = new System.Drawing.Point(12, 242);
            this.txtFilterByVehicleBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterByVehicleBrand.Name = "txtFilterByVehicleBrand";
            this.txtFilterByVehicleBrand.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtFilterByVehicleBrand.PlaceholderText = "Search By Vehicle Brand...";
            this.txtFilterByVehicleBrand.SelectedText = "";
            this.txtFilterByVehicleBrand.Size = new System.Drawing.Size(1149, 50);
            this.txtFilterByVehicleBrand.TabIndex = 3;
            this.txtFilterByVehicleBrand.TextChanged += new System.EventHandler(this.txtFilterByVehicleBrand_TextChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(23, 345);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(150, 34);
            this.guna2HtmlLabel4.TabIndex = 4;
            this.guna2HtmlLabel4.Text = "Filter Options";
            // 
            // dgvCarsList
            // 
            this.dgvCarsList.AllowUserToAddRows = false;
            this.dgvCarsList.AllowUserToDeleteRows = false;
            this.dgvCarsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvCarsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCarsList.ColumnHeadersHeight = 40;
            this.dgvCarsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCarsList.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCarsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCarsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvCarsList.Location = new System.Drawing.Point(10, 523);
            this.dgvCarsList.Name = "dgvCarsList";
            this.dgvCarsList.ReadOnly = true;
            this.dgvCarsList.RowHeadersVisible = false;
            this.dgvCarsList.Size = new System.Drawing.Size(1321, 348);
            this.dgvCarsList.TabIndex = 9;
            this.dgvCarsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvCarsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvCarsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvCarsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.dgvCarsList.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCarsList.ThemeStyle.ReadOnly = true;
            this.dgvCarsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCarsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvCarsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgvCarsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCarToolStripMenuItem,
            this.deleteCarToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(153, 56);
            // 
            // editCarToolStripMenuItem
            // 
            this.editCarToolStripMenuItem.Name = "editCarToolStripMenuItem";
            this.editCarToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.editCarToolStripMenuItem.Text = "Edit Car";
            this.editCarToolStripMenuItem.Click += new System.EventHandler(this.editCarToolStripMenuItem_Click);
            // 
            // deleteCarToolStripMenuItem
            // 
            this.deleteCarToolStripMenuItem.Name = "deleteCarToolStripMenuItem";
            this.deleteCarToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.deleteCarToolStripMenuItem.Text = "Delete Car";
            this.deleteCarToolStripMenuItem.Click += new System.EventHandler(this.deleteCarToolStripMenuItem_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(24, 485);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(140, 39);
            this.guna2HtmlLabel5.TabIndex = 10;
            this.guna2HtmlLabel5.Text = "Vehicle List";
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1341, 881);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.dgvCarsList);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtFilterByVehicleBrand);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.Name = "frmCars";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "frmCars";
            this.Load += new System.EventHandler(this.frmCars_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsList)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnAddNewVehicle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByVehicleBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByVehicleYear;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByVehicleBrand;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCarsList;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCarToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByModel;
        private Guna.UI2.WinForms.Guna2Button btnDeleteVehicle;
    }
}