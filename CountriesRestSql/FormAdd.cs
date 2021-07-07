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
    public partial class FormAdd : Form
    {
        CountryClass countryFind;
        public FormAdd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Finds and shows result of user's search
        /// </summary>
        private void btnFind_Click(object sender, EventArgs e)
        {
            RestClient restClient = new RestClient(tbFind.Text);
            string result = restClient.JsonCountry(ref countryFind);
            if (result == String.Empty)
            {
                rtbFindResult.Text = $"Country: {countryFind.Name}\n" +
                    $"Capital: {countryFind.Capital}\n" +
                    $"Calling code: {countryFind.CallingCodes}\n" +
                    $"Region: {countryFind.Region}\n" +
                    $"Area: {countryFind.Area}\n" +
                    $"Population: {countryFind.Population}\n";
            }
            else
            {
                rtbFindResult.Text = result;
            }
        }

        /// <summary>
        /// Adds country to a database
        /// </summary>
        private void btnAddDB_Click(object sender, EventArgs e)
        {
            if (countryFind != null)
            {
                rtbFindResult.Text = EntityThings.AddCountryToDB(countryFind);
                countryFind = null;
            }
            else
                rtbFindResult.Text = "Look for country first";
        }
    }
}
