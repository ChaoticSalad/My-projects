namespace Storage
{
    partial class FormReport
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbSortDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtProductName,
            this.txtStatus,
            this.txtDate,
            this.txtQuantity,
            this.txtCategoryName,
            this.txtCategoryDescription,
            this.txtCompanyName,
            this.txtCountry});
            this.dgvReport.Location = new System.Drawing.Point(12, 44);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(1007, 394);
            this.dgvReport.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.DataPropertyName = "Id";
            this.txtId.HeaderText = "Id";
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            // 
            // txtProductName
            // 
            this.txtProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtProductName.DataPropertyName = "Name";
            this.txtProductName.HeaderText = "ProductName";
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            // 
            // txtStatus
            // 
            this.txtStatus.DataPropertyName = "Status";
            this.txtStatus.HeaderText = "Status";
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            // 
            // txtDate
            // 
            this.txtDate.DataPropertyName = "Date";
            this.txtDate.HeaderText = "Date";
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.DataPropertyName = "Quantity";
            this.txtQuantity.HeaderText = "Quantity";
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.DataPropertyName = "Category";
            this.txtCategoryName.HeaderText = "CategoryName";
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ReadOnly = true;
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtCategoryDescription.DataPropertyName = "CategoryDesc";
            this.txtCategoryDescription.HeaderText = "CategoryDescription";
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.ReadOnly = true;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.DataPropertyName = "Company";
            this.txtCompanyName.HeaderText = "CompanyName";
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            // 
            // txtCountry
            // 
            this.txtCountry.DataPropertyName = "CompanyCountry";
            this.txtCountry.HeaderText = "Country";
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(792, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "To";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "All",
            "Entered",
            "Storage",
            "Sold"});
            this.cbStatus.Location = new System.Drawing.Point(423, 18);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 20;
            this.cbStatus.Text = "All";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Status";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Location = new System.Drawing.Point(586, 19);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 23;
            // 
            // dtpTo
            // 
            this.dtpTo.Enabled = false;
            this.dtpTo.Location = new System.Drawing.Point(818, 19);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 24;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(299, 16);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 25;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbSortDate
            // 
            this.cbSortDate.AutoSize = true;
            this.cbSortDate.Location = new System.Drawing.Point(553, 1);
            this.cbSortDate.Name = "cbSortDate";
            this.cbSortDate.Size = new System.Drawing.Size(83, 17);
            this.cbSortDate.TabIndex = 26;
            this.cbSortDate.Text = "Sort by date";
            this.cbSortDate.UseVisualStyleBackColor = true;
            this.cbSortDate.CheckedChanged += new System.EventHandler(this.cbSortDate_CheckedChanged);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.cbSortDate);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReport);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox cbSortDate;
    }
}