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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAll = new System.Windows.Forms.TabPage();
            this.dgvFull = new System.Windows.Forms.DataGridView();
            this.tpEntered = new System.Windows.Forms.TabPage();
            this.btnAddEnter = new System.Windows.Forms.Button();
            this.dgvEntered = new System.Windows.Forms.DataGridView();
            this.tpStorage = new System.Windows.Forms.TabPage();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.tpSold = new System.Windows.Forms.TabPage();
            this.dgvSold = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtIdStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductNameStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatusStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDateStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantityStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoryStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCompanyStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productExtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productExtBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tpAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).BeginInit();
            this.tpEntered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntered)).BeginInit();
            this.tpStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            this.tpSold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productExtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productExtBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
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
            this.dgvFull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFull.AutoGenerateColumns = false;
            this.dgvFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFull.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1,
            this.categoryDataGridViewTextBoxColumn1,
            this.categoryDescDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn1,
            this.companyCountryDataGridViewTextBoxColumn});
            this.dgvFull.DataSource = this.productExtBindingSource1;
            this.dgvFull.Location = new System.Drawing.Point(6, 6);
            this.dgvFull.Name = "dgvFull";
            this.dgvFull.ReadOnly = true;
            this.dgvFull.Size = new System.Drawing.Size(1166, 423);
            this.dgvFull.TabIndex = 0;
            this.dgvFull.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFull_CellMouseDown);
            this.dgvFull.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFull_MouseClick);
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
            this.dgvEntered.AutoGenerateColumns = false;
            this.dgvEntered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn});
            this.dgvEntered.DataSource = this.productBindingSource2;
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
            this.dgvSold.AutoGenerateColumns = false;
            this.dgvSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.quantityDataGridViewTextBoxColumn2,
            this.statusDataGridViewTextBoxColumn2,
            this.dateDataGridViewTextBoxColumn2,
            this.categoryDataGridViewTextBoxColumn2,
            this.companyDataGridViewTextBoxColumn2});
            this.dgvSold.DataSource = this.productBindingSource1;
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(197, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.txtProductNameStorage.HeaderText = "Name";
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
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Storage.Product);
            // 
            // productExtBindingSource
            // 
            this.productExtBindingSource.DataSource = typeof(Storage.ProductExt);
            // 
            // productExtBindingSource1
            // 
            this.productExtBindingSource1.DataSource = typeof(Storage.ProductExt);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn1
            // 
            this.categoryDataGridViewTextBoxColumn1.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn1.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn1.Name = "categoryDataGridViewTextBoxColumn1";
            this.categoryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoryDescDataGridViewTextBoxColumn
            // 
            this.categoryDescDataGridViewTextBoxColumn.DataPropertyName = "CategoryDesc";
            this.categoryDescDataGridViewTextBoxColumn.HeaderText = "CategoryDesc";
            this.categoryDescDataGridViewTextBoxColumn.Name = "categoryDescDataGridViewTextBoxColumn";
            this.categoryDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn1
            // 
            this.companyDataGridViewTextBoxColumn1.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn1.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn1.Name = "companyDataGridViewTextBoxColumn1";
            this.companyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // companyCountryDataGridViewTextBoxColumn
            // 
            this.companyCountryDataGridViewTextBoxColumn.DataPropertyName = "CompanyCountry";
            this.companyCountryDataGridViewTextBoxColumn.HeaderText = "CompanyCountry";
            this.companyCountryDataGridViewTextBoxColumn.Name = "companyCountryDataGridViewTextBoxColumn";
            this.companyCountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(Storage.Product);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn2
            // 
            this.quantityDataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn2.Name = "quantityDataGridViewTextBoxColumn2";
            this.quantityDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn2
            // 
            this.statusDataGridViewTextBoxColumn2.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn2.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn2.Name = "statusDataGridViewTextBoxColumn2";
            this.statusDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn2
            // 
            this.dateDataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn2.Name = "dateDataGridViewTextBoxColumn2";
            this.dateDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn2
            // 
            this.categoryDataGridViewTextBoxColumn2.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn2.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn2.Name = "categoryDataGridViewTextBoxColumn2";
            this.categoryDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn2
            // 
            this.companyDataGridViewTextBoxColumn2.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn2.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn2.Name = "companyDataGridViewTextBoxColumn2";
            this.companyDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataSource = typeof(Storage.Product);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 505);
            this.Controls.Add(this.btnUpdate);
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
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productExtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productExtBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
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
        private System.Windows.Forms.Button btnAddEnter;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productExtBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProductNameStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatusStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDateStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantityStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategoryStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCompanyStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productExtBindingSource;
    }
}

