using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency
{
    public partial class Form1 : Form
    {
        Logic logic;
        string lblFor;
        string tbFor;
        string tbRub;
        public Form1()
        {
            logic = new Logic();
            InitializeComponent();
        }

        /// <summary>
        /// When program starting, load default valute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            logic.ValuteChanged(ref lblFor, ref tbFor, ref tbRub);
            tbRubles.Text = tbRub;
            lblForeign.Text = lblFor;
            tbForeign.Text = tbFor;
        }

        /// <summary>
        /// Changing foreign's textbox when ruble's tb changed and avoiding stack overflow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbRubles_TextChanged(object sender, EventArgs e)
        {
            tbForeign.TextChanged -= tbForeign_TextChanged;
            try
            {
                tbForeign.Text = logic.RublesChanged(tbRubles.Text);
            }
            finally
            {
                tbForeign.TextChanged += tbForeign_TextChanged;
            }
            
        }

        /// <summary>
        /// Changing ruble's textbox when foreign's tb changed and avoiding stack overflow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbForeign_TextChanged(object sender, EventArgs e)
        {
            tbRubles.TextChanged -= tbRubles_TextChanged;
            try
            {
                tbRubles.Text = logic.ForeignChanged(tbForeign.Text);
            }
            finally
            {
                tbRubles.TextChanged += tbRubles_TextChanged;
            }
        }
    }
}
