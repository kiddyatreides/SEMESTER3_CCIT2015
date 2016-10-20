using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet.tb_employee' table. You can move, or remove it, as needed.
            this.tb_employeeTableAdapter.Fill(this.hRDataSet.tb_employee);
            // TODO: This line of code loads data into the 'latihanDataSet.tb_employee' table. You can move, or remove it, as needed
            this.tb_employeeTableAdapter.Fill(this.hRDataSet.tb_employee);
            txtCode.Enabled = false;
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtState.Enabled = false;
            txtCountry.Enabled = false;
            cbDesignation.Enabled = false;
            cbDepartment.Enabled = false;
            cbDesignation.Items.Add("MANAGER");
            cbDesignation.Items.Add("SUPERVISOR");
            cbDesignation.Items.Add("STAFF");
            cbDepartment.Items.Add("HRD");
            cbDepartment.Items.Add("TV Program");
            cbDepartment.Items.Add("Marketing");
            cmdSave.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtState.Enabled = true;
            txtCountry.Enabled = true;
            cbDesignation.Enabled = true;
            cbDepartment.Enabled = true;
            txtName.Text = "";
            txtAddress.Text = "";
            txtState.Text = "";
            txtCountry.Text = "";
            cbDesignation.Text = "";
            cbDepartment.Text = "";

            int ctr, len;
            string codeval;
            dt = hRDataSet.Tables["tb_employee"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["code"].ToString();
            codeval = code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                txtCode.Text = "E00" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 99))
            {
                ctr = ctr + 1;
                txtCode.Text = "E0" + ctr;
            }
            else if (ctr >= 99)
            {
                ctr = ctr + 1;
                txtCode.Text = "E" + ctr;
            }
            cmdAdd.Enabled = false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            dt = hRDataSet.Tables["tb_employee"];
            dr = dt.NewRow();
            dr[0] = txtCode.Text;
            dr[1] = txtName.Text;
            dr[2] = txtAddress.Text;
            dr[3] = txtState.Text;
            dr[4] = txtCountry.Text;
            dr[5] = cbDesignation.SelectedItem;
            dr[6] = cbDepartment.SelectedItem;
            dt.Rows.Add(dr);
            tb_employeeTableAdapter.Update(hRDataSet);
            txtCode.Text = System.Convert.ToString(dr[0]);
            txtCode.Enabled = false;
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtState.Enabled = false;
            txtCountry.Enabled = false;
            cbDesignation.Enabled = false;
            cbDepartment.Enabled = false;
            this.tb_employeeTableAdapter.Fill(this.hRDataSet.tb_employee);
            cmdAdd.Enabled = true;
            cmdSave.Enabled = false;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            string code;
            code = txtCode.Text;
            dr = hRDataSet.Tables["tb_employee"].Rows.Find(code);
            dr.Delete();
            tb_employeeTableAdapter.Update(hRDataSet);
        }
    }
}
