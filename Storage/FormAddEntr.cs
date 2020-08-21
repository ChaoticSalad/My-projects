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
    public partial class FormAddEntr : Form
    {
        public FormAddEntr()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int quantityEntr;
            if (tbName.Text != String.Empty && (tbQuantity.Text != String.Empty && tbQuantity.Text != "0" && Int32.TryParse(tbQuantity.Text,out quantityEntr)))
            {
                Product product = new Product(tbName.Text, "Entered", dtpAdd.Value.Date, quantityEntr, cbCategory.Text, cbCompany.Text);
                this.Close();
            }
            else
                MessageBox.Show($"Please, check entered values", "Wrong values entered");
        }
    }
}
