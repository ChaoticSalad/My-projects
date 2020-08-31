using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesRestSql
{
    public partial class Form1 : Form
    {
        //Country countryModel = new Country();
        //City cityModel = new City();
        //Region regionModel = new Region();

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens new form, in which you can find and add countries to a database
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
            formAdd = null;
            PopulateDataGridView();
            this.Show();
        }
        /// <summary>
        /// Loads datagridview when loading
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
        /// <summary>
        /// Populates datagridview from a database
        /// </summary>
        private void PopulateDataGridView()
        {
            dgvDBResults.DataSource = EntityThings.PopulateDataGridView();
            dgvDBResults.Refresh();

        }
    }
}
