using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GUI_Project
{
    public partial class FormBack : Form
    {
        public FormBack()
        {
            InitializeComponent();
        }

        

        private void addAirplaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_airplane obj = new Add_airplane();
           // obj.MdiParent = this;
            obj.Show();
        }

        private void displayAirplaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAirplane obj = new DisplayAirplane();
            obj.MdiParent = this;
            obj.Show();
        }

        private void airplaneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchAirplaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAirplane obj = new UpdateAirplane();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_flight obj = new Add_flight();
            obj.MdiParent = this;
            obj.Show();
        }

        private void displayFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayFlight obj = new DisplayFlight();
            //obj.MdiParent = this;
            obj.Show();
        }

        private void updateFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFlight obj = new UpdateFlight();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer obj = new AddCustomer();
            obj.MdiParent = this;
            obj.Show();
        }

        private void displayCostumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayCustomer obj = new DisplayCustomer();
            obj.MdiParent = this;
            obj.Show();
        }

        private void updateCostumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomer obj = new UpdateCustomer();
            obj.MdiParent = this;
            obj.Show();
        }

        private void reportCostumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testing obj = new Testing();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addTickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTicket obj = new AddTicket();
            //obj.MdiParent = this;
            obj.Show();
        }

        private void displayTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayTicket obj = new DisplayTicket();
            //obj.MdiParent = this;
            obj.Show();
        }

        private void FormBack_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                LoginForm obj = new LoginForm();
                this.Hide();
                obj.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something 
                FormBack obj = new FormBack();
                obj.MdiParent = this;
                obj.Show();

            }
        }
    }
}
