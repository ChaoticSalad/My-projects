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
    public partial class FormEdit : Form
    {
        Product productToEdit;
        //int idToEdit;
        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            ////idToEdit = Form1.IdSell;
            //List<Product> productsEdit = new List<Product>();
            //productsEdit.Add(productToEdit = new Product(Form1.IdSell));
            productToEdit = new Product(Form1.IdSell);
            dgvEdit.DataSource = productToEdit;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
