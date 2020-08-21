namespace Storage
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAll = new System.Windows.Forms.TabPage();
            this.dgvFull = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpEntered = new System.Windows.Forms.TabPage();
            this.btnAddEnter = new System.Windows.Forms.Button();
            this.dgvEntered = new System.Windows.Forms.DataGridView();
            this.tpStorage = new System.Windows.Forms.TabPage();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.txtIdStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductNameStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatusStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDateStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantityStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoryStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCompanyStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpSold = new System.Windows.Forms.TabPage();
            this.dgvSold = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).BeginInit();
            this.tpEntered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntered)).BeginInit();
            this.tpStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            this.tpSold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSold)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAll);
            this.tabControl1.Controls.Add(this.tpEntered);
            this.tabControl1.Controls.Add(this.tpStorage);
            this.tabControl1.Controls.Add(this.tpSold);
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1186, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAll
            // 
            this.tpAll.Controls.Add(this.dgvFull);
            this.tpAll.Location = new System.Drawing.Point(4, 22);
            this.tpAll.Name = "tpAll";
            this.tpAll.Padding = new System.Windows.Forms.Padding(3);
            this.tpAll.Size = new System.Drawing.Size(1178, 435);
            this.tpAll.TabIndex = 0;
            this.tpAll.Text = "All products";
            this.tpAll.UseVisualStyleBackColor = true;
            // 
            // dgvFull
            // 
            this.dgvFull.AllowUserToAddRows = false;
            this.dgvFull.AllowUserToDeleteRows = false;
            this.dgvFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFull.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtProductName,
            this.txtStatus,
            this.txtDate,
            this.txtQuantity,
            this.txtCategoryName,
            this.txtCategoryDescription,
            this.txtCompanyName,
            this.txtCountry});
            this.dgvFull.Location = new System.Drawing.Point(6, 6);
            this.dgvFull.Name = "dgvFull";
            this.dgvFull.ReadOnly = true;
            this.dgvFull.Size = new System.Drawing.Size(1166, 423);
            this.dgvFull.TabIndex = 0;
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
            // tpEntered
            // 
            this.tpEntered.Controls.Add(this.btnAddEnter);
            this.tpEntered.Controls.Add(this.dgvEntered);
            this.tpEntered.Location = new System.Drawing.Point(4, 22);
            this.tpEntered.Name = "tpEntered";
            this.tpEntered.Padding = new System.Windows.Forms.Padding(3);
            this.tpEntered.Size = new System.Drawing.Size(1178, 435);
            this.tpEntered.TabIndex = 1;
            this.tpEntered.Text = "Entered products";
            this.tpEntered.UseVisualStyleBackColor = true;
            // 
            // btnAddEnter
            // 
            this.btnAddEnter.Location = new System.Drawing.Point(6, 6);
            this.btnAddEnter.Name = "btnAddEnter";
            this.btnAddEnter.Size = new System.Drawing.Size(75, 23);
            this.btnAddEnter.TabIndex = 1;
            this.btnAddEnter.Text = "Add new product";
            this.btnAddEnter.UseVisualStyleBackColor = true;
            this.btnAddEnter.Click += new System.EventHandler(this.btnAddEnter_Click);
            // 
            // dgvEntered
            // 
            this.dgvEntered.AllowUserToAddRows = false;
            this.dgvEntered.AllowUserToDeleteRows = false;
            this.dgvEntered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntered.Location = new System.Drawing.Point(7, 35);
            this.dgvEntered.Name = "dgvEntered";
            this.dgvEntered.ReadOnly = true;
            this.dgvEntered.Size = new System.Drawing.Size(1165, 394);
            this.dgvEntered.TabIndex = 0;
            // 
            // tpStorage
            // 
            this.tpStorage.Controls.Add(this.dgvStorage);
            this.tpStorage.Location = new System.Drawing.Point(4, 22);
            this.tpStorage.Name = "tpStorage";
            this.tpStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tpStorage.Size = new System.Drawing.Size(1178, 435);
            this.tpStorage.TabIndex = 2;
            this.tpStorage.Text = "Storage products";
            this.tpStorage.UseVisualStyleBackColor = true;
            // 
            // dgvStorage
            // 
            this.dgvStorage.AllowUserToAddRows = false;
            this.dgvStorage.AllowUserToDeleteRows = false;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdStorage,
            this.txtProductNameStorage,
            this.txtStatusStorage,
            this.txtDateStorage,
            this.txtQuantityStorage,
            this.txtCategoryStorage,
            this.txtCompanyStorage});
            this.dgvStorage.Location = new System.Drawing.Point(7, 7);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.ReadOnly = true;
            this.dgvStorage.Size = new System.Drawing.Size(1165, 422);
            this.dgvStorage.TabIndex = 0;
            this.dgvStorage.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStorage_CellMouseDown);
            this.dgvStorage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvStorage_MouseClick);
            // 
            // txtIdStorage
            // 
            this.txtIdStorage.DataPropertyName = "Id";
            this.txtIdStorage.HeaderText = "id";
            this.txtIdStorage.Name = "txtIdStorage";
            this.txtIdStorage.ReadOnly = true;
            // 
            // txtProductNameStorage
            // 
            this.txtProductNameStorage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtProductNameStorage.DataPropertyName = "Name";
            this.txtProductNameStorage.HeaderText = "ProductName";
            this.txtProductNameStorage.Name = "txtProductNameStorage";
            this.txtProductNameStorage.ReadOnly = true;
            // 
            // txtStatusStorage
            // 
            this.txtStatusStorage.DataPropertyName = "Status";
            this.txtStatusStorage.HeaderText = "Status";
            this.txtStatusStorage.Name = "txtStatusStorage";
            this.txtStatusStorage.ReadOnly = true;
            // 
            // txtDateStorage
            // 
            this.txtDateStorage.DataPropertyName = "Date";
            this.txtDateStorage.HeaderText = "Date";
            this.txtDateStorage.Name = "txtDateStorage";
            this.txtDateStorage.ReadOnly = true;
            // 
            // txtQuantityStorage
            // 
            this.txtQuantityStorage.DataPropertyName = "Quantity";
            this.txtQuantityStorage.HeaderText = "Quantity";
            this.txtQuantityStorage.Name = "txtQuantityStorage";
            this.txtQuantityStorage.ReadOnly = true;
            // 
            // txtCategoryStorage
            // 
            this.txtCategoryStorage.DataPropertyName = "Category";
            this.txtCategoryStorage.HeaderText = "Category";
            this.txtCategoryStorage.Name = "txtCategoryStorage";
            this.txtCategoryStorage.ReadOnly = true;
            // 
            // txtCompanyStorage
            // 
            this.txtCompanyStorage.DataPropertyName = "Company";
            this.txtCompanyStorage.HeaderText = "Company";
            this.txtCompanyStorage.Name = "txtCompanyStorage";
            this.txtCompanyStorage.ReadOnly = true;
            // 
            // tpSold
            // 
            this.tpSold.Controls.Add(this.dgvSold);
            this.tpSold.Location = new System.Drawing.Point(4, 22);
            this.tpSold.Name = "tpSold";
            this.tpSold.Padding = new System.Windows.Forms.Padding(3);
            this.tpSold.Size = new System.Drawing.Size(1178, 435);
            this.tpSold.TabIndex = 3;
            this.tpSold.Text = "Sold products";
            this.tpSold.UseVisualStyleBackColor = true;
            // 
            // dgvSold
            // 
            this.dgvSold.AllowUserToAddRows = false;
            this.dgvSold.AllowUserToDeleteRows = false;
            this.dgvSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSold.Location = new System.Drawing.Point(6, 6);
            this.dgvSold.Name = "dgvSold";
            this.dgvSold.ReadOnly = true;
            this.dgvSold.Size = new System.Drawing.Size(1166, 423);
            this.dgvSold.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(116, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 505);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Storage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).EndInit();
            this.tpEntered.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntered)).EndInit();
            this.tpStorage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            this.tpSold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAll;
        private System.Windows.Forms.TabPage tpEntered;
        private System.Windows.Forms.DataGridView dgvFull;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvEntered;
        private System.Windows.Forms.TabPage tpStorage;
        private System.Windows.Forms.DataGridView dgvStorage;
        private System.Windows.Forms.TabPage tpSold;
        private System.Windows.Forms.DataGridView dgvSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCountry;
        private System.Windows.Forms.Button btnAddEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProductNameStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatusStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDateStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantityStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategoryStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCompanyStorage;
        private System.Windows.Forms.Button btnReport;
    }
}

