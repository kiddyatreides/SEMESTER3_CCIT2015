using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentHouse
{
    public partial class RMonthlyPaid : Form
    {
        public RMonthlyPaid()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void RMonthlyPaid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rent_houseDataSet.tb_monthly_paid' table. You can move, or remove it, as needed.
            this.tb_monthly_paidTableAdapter.Fill(this.rent_houseDataSet.tb_monthly_paid);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
