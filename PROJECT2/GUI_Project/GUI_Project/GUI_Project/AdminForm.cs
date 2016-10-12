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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFlight obj = new AddFlight();
            obj.MdiParent = this;
            obj.Show();
        }

        private void displayFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayFlight obj = new DisplayFlight();
            obj.MdiParent = this;
            obj.Show();
        }

        private void updateFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFlight obj = new UpdateFlight();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addAirplaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_airplane obj = new Add_airplane();
            obj.MdiParent = this;
            obj.Show();
        }

        private void displayAirplaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAirplane obj = new DisplayAirplane();
            obj.MdiParent = this;
            obj.Show();
        }

        private void updateAirplaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAirplane obj = new UpdateAirplane();
            obj.MdiParent = this;
            obj.Show();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
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
                AdminForm obj = new AdminForm();
                obj.MdiParent = this;
                obj.Show();

            }
        }
    }
}
