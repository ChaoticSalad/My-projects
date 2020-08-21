using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class FormReport : Form
    {
        public List<ProductExt> ProductExts;
        Form1 form1;
        public FormReport()
        {
            form1 = new Form1();
            ProductExts = ProductExt.GetProductExts();
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            var productExts = this.ProductExts;
            dgvReport.DataSource = productExts;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            form1 = new Form1();
            form1.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.ProductExts.Clear();
            if (cbStatus.Text == "All" && cbSortDate.Checked)
            {
                ProductExts = ProductExt.GetProductExtsDate(dtpFrom.Value.Date, dtpTo.Value.Date);
                var productExtsDate = this.ProductExts;
                ProductExt.SortByDate(productExtsDate);
                dgvReport.DataSource = productExtsDate;
            }
            else if (cbStatus.Text != "All" && !cbSortDate.Checked)
            {
                ProductExts = ProductExt.GetProductExtsStatus(cbStatus.Text);
                var productExtsStatus = this.ProductExts;
                ProductExt.SortByDate(productExtsStatus);
                dgvReport.DataSource = productExtsStatus;
            }
            else if (cbStatus.Text != "All" && cbSortDate.Checked)
            {
                ProductExts = ProductExt.GetProductExtsDateStatus(dtpFrom.Value.Date, dtpTo.Value.Date, cbStatus.Text);
                var productExtsDateStatus = this.ProductExts;
                ProductExt.SortByDate(productExtsDateStatus);
                dgvReport.DataSource = productExtsDateStatus;
            }
            else
            {
                ProductExts = ProductExt.GetProductExts();
                var productExts = this.ProductExts;
                ProductExt.SortByStatus(productExts);
                dgvReport.DataSource = productExts;
            }

        }

        private void cbSortDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSortDate.Checked)
            {
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
            }
            else
            {
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
            }
        }
    }
}
