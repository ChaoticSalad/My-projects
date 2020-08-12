using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHive
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            cbWorkerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care" , "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);
            queen = new Queen(workers, 275);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(cbWorkerBeeJob.Text, Convert.ToInt32(nudShifts.Value)) == false)
                MessageBox.Show("No workers for this work " + cbWorkerBeeJob.Text, "Queen says...");
            else
                MessageBox.Show("Work " + cbWorkerBeeJob.Text + " will be finished in " + nudShifts.Value + " shifts", "Queen says...");
        }

        private void btnNextShift_Click(object sender, EventArgs e)
        {
            textBox1.Text = queen.WorkTheNextShift();
        }

        private void cbWorkerBeeJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudShifts_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
