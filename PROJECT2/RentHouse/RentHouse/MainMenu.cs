using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RentHouse
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void monthlyPaidDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void customerPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer objcp = new Customer();
            objcp.Show();
        }

        private void displayCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DisplayCustomerr obj = new DisplayCustomerr();
            obj.Show();
        }

        private void roomPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room objrm = new Room();
            objrm.Show();
        }

        private void roomDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayRoom objdrm = new DisplayRoom();
            objdrm.Show();
        }

        private void laundryPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laundry objln = new Laundry();
            objln.Show();
        }

        private void displayLaundryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayLaundry objdl = new DisplayLaundry();
            objdl.Show();
        }

        private void rentPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rent objrn = new Rent();
            objrn.Show();
        }

        private void displayRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayRent objdrn = new DisplayRent();
            objdrn.Show();
        }

        private void displayMonthlyPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayMonthlyPaid objdm = new DisplayMonthlyPaid();
            objdm.Show();
        }

        private void rentInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentIn obj = new RentIn();
            obj.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout ?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login obj = new Login();
                obj.Show();

            }
            else if (result == DialogResult.No)
            {
                
            }
        }

        private void typeRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomType obj = new RoomType();
            obj.Show();
        }

        private void reportMonthlyPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMonthlyPaid obj = new RMonthlyPaid();
            obj.Show();
        }
    }
}
