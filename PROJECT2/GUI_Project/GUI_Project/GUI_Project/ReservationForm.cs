using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void buyTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTicket obj = new AddTicket();
            obj.MdiParent = this;
            obj.Show();
        }

        private void displayTicketSellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayTicket obj = new DisplayTicket();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer obj = new AddCustomer();
            obj.MdiParent = this;
            obj.Show();
        }

        private void displayCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayCustomer obj = new DisplayCustomer();
            obj.MdiParent = this;
            obj.Show();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomer obj = new UpdateCustomer();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ReservationForm_FormClosed(object sender, FormClosedEventArgs e)
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
                ReservationForm obj = new ReservationForm();
                obj.MdiParent = this;
                obj.Show();
                
            }
        }
    }
}
