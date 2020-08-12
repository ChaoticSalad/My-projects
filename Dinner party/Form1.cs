using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, cbHealthy.Checked, cbFancy.Checked);
            DisplayDinnerPartyCost();
            birthdayParty = new BirthdayParty((int)nudBirthday.Value, cbFancy.Checked, tbCakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            lblCost.Text = Cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            lblTooLong.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            lblBirthdayCost.Text = cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void cbFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = cbFancy.Checked;
            DisplayDinnerPartyCost();
        }

        private void cbHealthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = cbHealthy.Checked;
            DisplayDinnerPartyCost();
        }

        private void tbBirthday_Click(object sender, EventArgs e)
        {

        }

        private void nudBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)nudBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void cbFancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = cbFancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void tbCakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = tbCakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        private void lblBirthdayCost_Click(object sender, EventArgs e)
        {

        }
    }
}
