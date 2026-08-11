namespace Car_Rental_Project
{
    partial class frmCustomerScreen
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDeleteCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSortByNationalID = new Guna.UI2.WinForms.Guna2Button();
            this.btnSortByName = new Guna.UI2.WinForms.Guna2Button();
            this.lblFilterTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFilterByName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerListTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvCustomerList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsCustomerMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.cmsCustomerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnDeleteCustomer);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnAddNewCustomer);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1341, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCustomer.Animated = true;
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCustomer.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteCustomer.BorderRadius = 8;
            this.btnDeleteCustomer.BorderThickness = 5;
            this.btnDeleteCustomer.FillColor = System.Drawing.Color.Black;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.Snow;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(850, 20);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(212, 50);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "- Delete Customer";
            this.btnDeleteCustomer.UseTransparentBackground = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(312, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Management";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewCustomer.Animated = true;
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewCustomer.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAddNewCustomer.BorderRadius = 8;
            this.btnAddNewCustomer.BorderThickness = 5;
            this.btnAddNewCustomer.FillColor = System.Drawing.Color.Black;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(1105, 20);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(212, 50);
            this.btnAddNewCustomer.TabIndex = 1;
            this.btnAddNewCustomer.Text = "+ Add New Customer";
            this.btnAddNewCustomer.UseTransparentBackground = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlFilter.BorderRadius = 10;
            this.pnlFilter.BorderThickness = 1;
            this.pnlFilter.Controls.Add(this.btnSortByNationalID);
            this.pnlFilter.Controls.Add(this.btnSortByName);
            this.pnlFilter.Controls.Add(this.lblFilterTitle);
            this.pnlFilter.Controls.Add(this.txtFilterByName);
            this.pnlFilter.FillColor = System.Drawing.Color.White;
            this.pnlFilter.Location = new System.Drawing.Point(24, 110);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1293, 130);
            this.pnlFilter.TabIndex = 1;
            // 
            // btnSortByNationalID
            // 
            this.btnSortByNationalID.Animated = true;
            this.btnSortByNationalID.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortByNationalID.BorderRadius = 8;
            this.btnSortByNationalID.BorderThickness = 3;
            this.btnSortByNationalID.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortByNationalID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortByNationalID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortByNationalID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortByNationalID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSortByNationalID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSortByNationalID.ForeColor = System.Drawing.Color.Black;
            this.btnSortByNationalID.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btnSortByNationalID.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSortByNationalID.Location = new System.Drawing.Point(1003, 58);
            this.btnSortByNationalID.Name = "btnSortByNationalID";
            this.btnSortByNationalID.Size = new System.Drawing.Size(225, 48);
            this.btnSortByNationalID.TabIndex = 5;
            this.btnSortByNationalID.Text = "NationalID";
            this.btnSortByNationalID.Click += new System.EventHandler(this.btnSortByNationalID_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.Animated = true;
            this.btnSortByName.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortByName.BorderRadius = 8;
            this.btnSortByName.BorderThickness = 3;
            this.btnSortByName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortByName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortByName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortByName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortByName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSortByName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSortByName.ForeColor = System.Drawing.Color.Black;
            this.btnSortByName.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btnSortByName.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSortByName.Location = new System.Drawing.Point(705, 58);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(225, 48);
            this.btnSortByName.TabIndex = 4;
            this.btnSortByName.Text = "FullName";
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblFilterTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(214, 27);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "Search && Filter Options";
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Animated = true;
            this.txtFilterByName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtFilterByName.BorderRadius = 8;
            this.txtFilterByName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterByName.DefaultText = "";
            this.txtFilterByName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtFilterByName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtFilterByName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtFilterByName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtFilterByName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtFilterByName.Location = new System.Drawing.Point(20, 58);
            this.txtFilterByName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtFilterByName.PlaceholderText = "🔍  Search by Customer Name...";
            this.txtFilterByName.SelectedText = "";
            this.txtFilterByName.Size = new System.Drawing.Size(600, 48);
            this.txtFilterByName.TabIndex = 1;
            this.txtFilterByName.TextChanged += new System.EventHandler(this.txtFilterByName_TextChanged);
            // 
            // lblCustomerListTitle
            // 
            this.lblCustomerListTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblCustomerListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCustomerListTitle.Location = new System.Drawing.Point(24, 255);
            this.lblCustomerListTitle.Name = "lblCustomerListTitle";
            this.lblCustomerListTitle.Size = new System.Drawing.Size(143, 32);
            this.lblCustomerListTitle.TabIndex = 2;
            this.lblCustomerListTitle.Text = "Customers List";
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            this.dgvCustomerList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvCustomerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerList.ColumnHeadersHeight = 42;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomerList.ContextMenuStrip = this.cmsCustomerMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvCustomerList.Location = new System.Drawing.Point(24, 298);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.RowTemplate.Height = 38;
            this.dgvCustomerList.Size = new System.Drawing.Size(1293, 550);
            this.dgvCustomerList.TabIndex = 3;
            this.dgvCustomerList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvCustomerList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvCustomerList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvCustomerList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvCustomerList.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvCustomerList.ThemeStyle.ReadOnly = true;
            this.dgvCustomerList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvCustomerList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgvCustomerList.ThemeStyle.RowsStyle.Height = 38;
            this.dgvCustomerList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.dgvCustomerList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            // 
            // cmsCustomerMenu
            // 
            this.cmsCustomerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
            this.cmsCustomerMenu.Name = "cmsCustomerMenu";
            this.cmsCustomerMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cmsCustomerMenu.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cmsCustomerMenu.RenderStyle.ColorTable = null;
            this.cmsCustomerMenu.RenderStyle.RoundedEdges = true;
            this.cmsCustomerMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsCustomerMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cmsCustomerMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsCustomerMenu.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cmsCustomerMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsCustomerMenu.Size = new System.Drawing.Size(197, 56);
            // 
            // editCustomerToolStripMenuItem
            // 
            this.editCustomerToolStripMenuItem.Name = "editCustomerToolStripMenuItem";
            this.editCustomerToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.editCustomerToolStripMenuItem.Text = "Edit Customer";
            this.editCustomerToolStripMenuItem.Click += new System.EventHandler(this.editCustomerToolStripMenuItem_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem_Click);
            // 
            // frmCustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1341, 881);
            this.Controls.Add(this.dgvCustomerList);
            this.Controls.Add(this.lblCustomerListTitle);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmCustomerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.frmCustomerScreen_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.cmsCustomerMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCustomer;
        private Guna.UI2.WinForms.Guna2Panel pnlFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFilterTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerListTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomerList;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsCustomerMenu;
        private Guna.UI2.WinForms.Guna2Button btnSortByNationalID;
        private Guna.UI2.WinForms.Guna2Button btnSortByName;
        private System.Windows.Forms.ToolStripMenuItem editCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCustomer;
    }
}