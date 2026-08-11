namespace Car_Rental_Project
{
    partial class frmDeleteCar
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
            this.lbTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlSearchCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSearchID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearchID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDetailsCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBrandTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBrandValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblModelTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblModelValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPlateTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPlateValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblYearPriceTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblYearPriceValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlWarningBox = new Guna.UI2.WinForms.Guna2Panel();
            this.lblWarningText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlSearchCard.SuspendLayout();
            this.pnlDetailsCard.SuspendLayout();
            this.pnlWarningBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lbTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(580, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(25, 16);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(142, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Delete Vehicle";
            // 
            // pnlSearchCard
            // 
            this.pnlSearchCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlSearchCard.BorderRadius = 10;
            this.pnlSearchCard.BorderThickness = 1;
            this.pnlSearchCard.Controls.Add(this.lblSearchID);
            this.pnlSearchCard.Controls.Add(this.txtSearchID);
            this.pnlSearchCard.Controls.Add(this.btnSearch);
            this.pnlSearchCard.FillColor = System.Drawing.Color.White;
            this.pnlSearchCard.Location = new System.Drawing.Point(25, 80);
            this.pnlSearchCard.Name = "pnlSearchCard";
            this.pnlSearchCard.Size = new System.Drawing.Size(530, 75);
            this.pnlSearchCard.TabIndex = 1;
            // 
            // lblSearchID
            // 
            this.lblSearchID.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSearchID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblSearchID.Location = new System.Drawing.Point(20, 12);
            this.lblSearchID.Name = "lblSearchID";
            this.lblSearchID.Size = new System.Drawing.Size(101, 19);
            this.lblSearchID.TabIndex = 0;
            this.lblSearchID.Text = "Enter Vehicle ID:";
            // 
            // txtSearchID
            // 
            this.txtSearchID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtSearchID.BorderRadius = 6;
            this.txtSearchID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchID.DefaultText = "";
            this.txtSearchID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtSearchID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtSearchID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtSearchID.Location = new System.Drawing.Point(20, 32);
            this.txtSearchID.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.PlaceholderText = "e.g. 102";
            this.txtSearchID.SelectedText = "";
            this.txtSearchID.Size = new System.Drawing.Size(360, 34);
            this.txtSearchID.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 6;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(390, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Find Vehicle";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlDetailsCard
            // 
            this.pnlDetailsCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDetailsCard.BorderRadius = 10;
            this.pnlDetailsCard.BorderThickness = 1;
            this.pnlDetailsCard.Controls.Add(this.lblBrandTitle);
            this.pnlDetailsCard.Controls.Add(this.lblBrandValue);
            this.pnlDetailsCard.Controls.Add(this.lblModelTitle);
            this.pnlDetailsCard.Controls.Add(this.lblModelValue);
            this.pnlDetailsCard.Controls.Add(this.lblPlateTitle);
            this.pnlDetailsCard.Controls.Add(this.lblPlateValue);
            this.pnlDetailsCard.Controls.Add(this.lblYearPriceTitle);
            this.pnlDetailsCard.Controls.Add(this.lblYearPriceValue);
            this.pnlDetailsCard.Controls.Add(this.pnlWarningBox);
            this.pnlDetailsCard.FillColor = System.Drawing.Color.White;
            this.pnlDetailsCard.Location = new System.Drawing.Point(25, 170);
            this.pnlDetailsCard.Name = "pnlDetailsCard";
            this.pnlDetailsCard.Size = new System.Drawing.Size(530, 245);
            this.pnlDetailsCard.TabIndex = 2;
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblBrandTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblBrandTitle.Location = new System.Drawing.Point(20, 20);
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.Size = new System.Drawing.Size(43, 17);
            this.lblBrandTitle.TabIndex = 0;
            this.lblBrandTitle.Text = "BRAND";
            // 
            // lblBrandValue
            // 
            this.lblBrandValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblBrandValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblBrandValue.Location = new System.Drawing.Point(20, 38);
            this.lblBrandValue.Name = "lblBrandValue";
            this.lblBrandValue.Size = new System.Drawing.Size(21, 21);
            this.lblBrandValue.TabIndex = 1;
            this.lblBrandValue.Text = "---";
            // 
            // lblModelTitle
            // 
            this.lblModelTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblModelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblModelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblModelTitle.Location = new System.Drawing.Point(280, 20);
            this.lblModelTitle.Name = "lblModelTitle";
            this.lblModelTitle.Size = new System.Drawing.Size(44, 17);
            this.lblModelTitle.TabIndex = 2;
            this.lblModelTitle.Text = "MODEL";
            // 
            // lblModelValue
            // 
            this.lblModelValue.BackColor = System.Drawing.Color.Transparent;
            this.lblModelValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblModelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblModelValue.Location = new System.Drawing.Point(280, 38);
            this.lblModelValue.Name = "lblModelValue";
            this.lblModelValue.Size = new System.Drawing.Size(21, 21);
            this.lblModelValue.TabIndex = 3;
            this.lblModelValue.Text = "---";
            // 
            // lblPlateTitle
            // 
            this.lblPlateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPlateTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPlateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPlateTitle.Location = new System.Drawing.Point(20, 75);
            this.lblPlateTitle.Name = "lblPlateTitle";
            this.lblPlateTitle.Size = new System.Drawing.Size(88, 17);
            this.lblPlateTitle.TabIndex = 4;
            this.lblPlateTitle.Text = "PLATE NUMBER";
            // 
            // lblPlateValue
            // 
            this.lblPlateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPlateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPlateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPlateValue.Location = new System.Drawing.Point(20, 93);
            this.lblPlateValue.Name = "lblPlateValue";
            this.lblPlateValue.Size = new System.Drawing.Size(21, 21);
            this.lblPlateValue.TabIndex = 5;
            this.lblPlateValue.Text = "---";
            // 
            // lblYearPriceTitle
            // 
            this.lblYearPriceTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblYearPriceTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblYearPriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblYearPriceTitle.Location = new System.Drawing.Point(280, 75);
            this.lblYearPriceTitle.Name = "lblYearPriceTitle";
            this.lblYearPriceTitle.Size = new System.Drawing.Size(107, 17);
            this.lblYearPriceTitle.TabIndex = 6;
            this.lblYearPriceTitle.Text = "YEAR / DAILY RATE";
            // 
            // lblYearPriceValue
            // 
            this.lblYearPriceValue.BackColor = System.Drawing.Color.Transparent;
            this.lblYearPriceValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblYearPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblYearPriceValue.Location = new System.Drawing.Point(280, 93);
            this.lblYearPriceValue.Name = "lblYearPriceValue";
            this.lblYearPriceValue.Size = new System.Drawing.Size(21, 21);
            this.lblYearPriceValue.TabIndex = 7;
            this.lblYearPriceValue.Text = "---";
            // 
            // pnlWarningBox
            // 
            this.pnlWarningBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.pnlWarningBox.BorderRadius = 6;
            this.pnlWarningBox.BorderThickness = 1;
            this.pnlWarningBox.Controls.Add(this.lblWarningText);
            this.pnlWarningBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlWarningBox.Location = new System.Drawing.Point(20, 140);
            this.pnlWarningBox.Name = "pnlWarningBox";
            this.pnlWarningBox.Size = new System.Drawing.Size(490, 80);
            this.pnlWarningBox.TabIndex = 8;
            // 
            // lblWarningText
            // 
            this.lblWarningText.BackColor = System.Drawing.Color.Transparent;
            this.lblWarningText.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblWarningText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblWarningText.Location = new System.Drawing.Point(15, 12);
            this.lblWarningText.Name = "lblWarningText";
            this.lblWarningText.Size = new System.Drawing.Size(347, 32);
            this.lblWarningText.TabIndex = 0;
            this.lblWarningText.Text = "<b>Warning:</b> This action cannot be undone. Deleting this vehicle will<br/>perm" +
    "anently remove it from the database inventory.";
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderRadius = 6;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(305, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(435, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDeleteCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(580, 485);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlDetailsCard);
            this.Controls.Add(this.pnlSearchCard);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDeleteCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Vehicle";
            this.Load += new System.EventHandler(this.frmDeleteCar_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearchCard.ResumeLayout(false);
            this.pnlSearchCard.PerformLayout();
            this.pnlDetailsCard.ResumeLayout(false);
            this.pnlDetailsCard.PerformLayout();
            this.pnlWarningBox.ResumeLayout(false);
            this.pnlWarningBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlSearchCard;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSearchID;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchID;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Panel pnlDetailsCard;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBrandTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBrandValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModelTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModelValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPlateTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPlateValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYearPriceTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYearPriceValue;
        private Guna.UI2.WinForms.Guna2Panel pnlWarningBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWarningText;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}