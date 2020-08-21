using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class Form1 : Form
    {
        public List<ProductExt> ProductExts;
        public List<Product> ProductsEntered;
        public List<Product> ProductsStorage;
        public List<Product> ProductsSold;
        FormReport formReport;
        FormAddEntr formAdd;
        FormCreate formCreate;
        private int rowIndex;
        public Form1()
        {
            ProductExts = ProductExt.GetProductExts();
            ProductsEntered = Product.GetProductsMod("STATUS", "Entered");
            ProductsStorage = Product.GetProductsMod("STATUS", "Storage");
            ProductsSold = Product.GetProductsMod("STATUS", "Sold");
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formCreate = new FormCreate();
            formCreate.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var productExts = this.ProductExts;
            dgvFull.DataSource = productExts;
            var productsEntr = this.ProductsEntered;
            dgvEntered.DataSource = productsEntr;
            var productsStr = this.ProductsStorage;
            dgvStorage.DataSource = productsStr;
            var productsSold = this.ProductsSold;
            dgvSold.DataSource = productsSold;
        }

        private void btnAddEnter_Click(object sender, EventArgs e)
        {
            formAdd = new FormAddEntr();
            formAdd.ShowDialog();
        }

        private void dgvStorage_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            if (e.Button == MouseButtons.Right)
            {
                var row = dataGrid.Rows[e.RowIndex];
                if (e.ColumnIndex == -1)
                    dataGrid.CurrentCell = row.Cells[1];
                else
                    dataGrid.CurrentCell = row.Cells[e.ColumnIndex];
                row.Selected = true;
                dataGrid.Focus();
                dgvStorage.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                dgvStorage.CurrentCell = dgvStorage.Rows[e.RowIndex].Cells[1];
            }
        }
        private void dgvStorage_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextSell = new ContextMenuStrip();
                int currentMouseOverRow = dgvStorage.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    contextSell.Items.Add("Sell ").Name = "Sell";
                }
                contextSell.Show(dgvStorage, new Point(e.X, e.Y));
                contextSell.ItemClicked += new ToolStripItemClickedEventHandler(contextSell_ItemClicked);
            }
        }

        private void contextSell_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "Sell")
            {
                int idSell = Convert.ToInt32(dgvStorage.Rows[rowIndex].Cells[0].Value);
                Product.SellProduct(idSell);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            formReport = new FormReport();
            formReport.Show();
        }
    }
}


