namespace Car_Rental_Project
{
    partial class frmDeleteCustomer
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
            this.lblFullNameTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFullNameValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNationalIDTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNationalIDValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPhoneTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPhoneValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCustomerIDTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCustomerIDValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            this.lbTitle.Size = new System.Drawing.Size(165, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Delete Customer";
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
            this.lblSearchID.Size = new System.Drawing.Size(118, 19);
            this.lblSearchID.TabIndex = 0;
            this.lblSearchID.Text = "Enter Customer ID:";
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
            this.txtSearchID.PlaceholderText = "e.g. 1";
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
            this.btnSearch.Text = "Find Customer";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlDetailsCard
            // 
            this.pnlDetailsCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDetailsCard.BorderRadius = 10;
            this.pnlDetailsCard.BorderThickness = 1;
            this.pnlDetailsCard.Controls.Add(this.lblFullNameTitle);
            this.pnlDetailsCard.Controls.Add(this.lblFullNameValue);
            this.pnlDetailsCard.Controls.Add(this.lblNationalIDTitle);
            this.pnlDetailsCard.Controls.Add(this.lblNationalIDValue);
            this.pnlDetailsCard.Controls.Add(this.lblPhoneTitle);
            this.pnlDetailsCard.Controls.Add(this.lblPhoneValue);
            this.pnlDetailsCard.Controls.Add(this.lblCustomerIDTitle);
            this.pnlDetailsCard.Controls.Add(this.lblCustomerIDValue);
            this.pnlDetailsCard.Controls.Add(this.pnlWarningBox);
            this.pnlDetailsCard.FillColor = System.Drawing.Color.White;
            this.pnlDetailsCard.Location = new System.Drawing.Point(25, 170);
            this.pnlDetailsCard.Name = "pnlDetailsCard";
            this.pnlDetailsCard.Size = new System.Drawing.Size(530, 245);
            this.pnlDetailsCard.TabIndex = 2;
            // 
            // lblFullNameTitle
            // 
            this.lblFullNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFullNameTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFullNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFullNameTitle.Location = new System.Drawing.Point(20, 20);
            this.lblFullNameTitle.Name = "lblFullNameTitle";
            this.lblFullNameTitle.Size = new System.Drawing.Size(66, 17);
            this.lblFullNameTitle.TabIndex = 0;
            this.lblFullNameTitle.Text = "FULL NAME";
            // 
            // lblFullNameValue
            // 
            this.lblFullNameValue.BackColor = System.Drawing.Color.Transparent;
            this.lblFullNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblFullNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblFullNameValue.Location = new System.Drawing.Point(20, 38);
            this.lblFullNameValue.Name = "lblFullNameValue";
            this.lblFullNameValue.Size = new System.Drawing.Size(21, 21);
            this.lblFullNameValue.TabIndex = 1;
            this.lblFullNameValue.Text = "---";
            this.lblFullNameValue.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNationalIDTitle
            // 
            this.lblNationalIDTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNationalIDTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNationalIDTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNationalIDTitle.Location = new System.Drawing.Point(280, 20);
            this.lblNationalIDTitle.Name = "lblNationalIDTitle";
            this.lblNationalIDTitle.Size = new System.Drawing.Size(79, 17);
            this.lblNationalIDTitle.TabIndex = 2;
            this.lblNationalIDTitle.Text = "NATIONAL ID";
            // 
            // lblNationalIDValue
            // 
            this.lblNationalIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblNationalIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblNationalIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNationalIDValue.Location = new System.Drawing.Point(280, 38);
            this.lblNationalIDValue.Name = "lblNationalIDValue";
            this.lblNationalIDValue.Size = new System.Drawing.Size(21, 21);
            this.lblNationalIDValue.TabIndex = 3;
            this.lblNationalIDValue.Text = "---";
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhoneTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPhoneTitle.Location = new System.Drawing.Point(20, 75);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(94, 17);
            this.lblPhoneTitle.TabIndex = 4;
            this.lblPhoneTitle.Text = "PHONE NUMBER";
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPhoneValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPhoneValue.Location = new System.Drawing.Point(20, 93);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(21, 21);
            this.lblPhoneValue.TabIndex = 5;
            this.lblPhoneValue.Text = "---";
            // 
            // lblCustomerIDTitle
            // 
            this.lblCustomerIDTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerIDTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerIDTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCustomerIDTitle.Location = new System.Drawing.Point(280, 75);
            this.lblCustomerIDTitle.Name = "lblCustomerIDTitle";
            this.lblCustomerIDTitle.Size = new System.Drawing.Size(81, 17);
            this.lblCustomerIDTitle.TabIndex = 6;
            this.lblCustomerIDTitle.Text = "CUSTOMER ID";
            // 
            // lblCustomerIDValue
            // 
            this.lblCustomerIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCustomerIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCustomerIDValue.Location = new System.Drawing.Point(280, 93);
            this.lblCustomerIDValue.Name = "lblCustomerIDValue";
            this.lblCustomerIDValue.Size = new System.Drawing.Size(21, 21);
            this.lblCustomerIDValue.TabIndex = 7;
            this.lblCustomerIDValue.Text = "---";
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
            this.lblWarningText.Size = new System.Drawing.Size(360, 32);
            this.lblWarningText.TabIndex = 0;
            this.lblWarningText.Text = "<b>Warning:</b> This action cannot be undone. Deleting this customer will<br/>per" +
    "manently remove them from the database records.";
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
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDeleteCustomer
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
            this.MinimizeBox = false;
            this.Name = "frmDeleteCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Customer";
            this.Load += new System.EventHandler(this.frmDeleteCustomer_Load);
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullNameTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullNameValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNationalIDTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNationalIDValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhoneTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhoneValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerIDTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerIDValue;
        private Guna.UI2.WinForms.Guna2Panel pnlWarningBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWarningText;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}