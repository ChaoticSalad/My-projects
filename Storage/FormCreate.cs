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
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int quantityAdd;
            if (tbName.Text != String.Empty && (tbQuantity.Text != String.Empty && tbQuantity.Text != "0" && Int32.TryParse(tbQuantity.Text, out quantityAdd)))
            {
                Product product = new Product(tbName.Text, cbStatus.Text, dtpCreate.Value.Date, quantityAdd, cbCategory.Text, cbCompany.Text);
                this.Close();
            }
            else
                MessageBox.Show("Please, check entered values", "Wrong values entered");
        }
    }
}
