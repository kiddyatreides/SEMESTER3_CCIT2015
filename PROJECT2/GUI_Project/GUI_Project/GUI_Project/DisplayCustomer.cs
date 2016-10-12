using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class DisplayCustomer : Form
    {
        public DisplayCustomer()
        {
            InitializeComponent();
        }

        private void DisplayCustomer_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        public void RefreshDataGrid()
        {

            FileStream F;
            StreamReader R;
            string str;
            int row = 0;
            F = new FileStream("Customer.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "ID Customer";
            dataGridView1.Columns[1].Name = "Full Name";
            dataGridView1.Columns[2].Name = "Gender";
            dataGridView1.Columns[3].Name = "ID Type";
            dataGridView1.Columns[4].Name = "Type Number";
            dataGridView1.Columns[5].Name = "Birthdate";
            dataGridView1.Columns[6].Name = "Address";


            while ((str = R.ReadLine()) != null)
            {
                dataGridView1.Rows.Add();
                String[] s = str.Split('#');
                for (int i = 0; i <= s.Count() - 1; i++)
                {
                    dataGridView1[i, row].Value = s[i];
                }
                row++;
            }
            R.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string line, cari;
            string[] strArray = new string[7];
            Boolean find = false;
            FileStream F;
            StreamReader R;


            //DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "ID Customer";
            dataGridView1.Columns[1].Name = "Full Name";
            dataGridView1.Columns[2].Name = "Gender";
            dataGridView1.Columns[3].Name = "ID Type";
            dataGridView1.Columns[4].Name = "Type Number";
            dataGridView1.Columns[5].Name = "Birthdate";
            dataGridView1.Columns[6].Name = "Address";
            F = new FileStream("Customer.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            cari = tbox_search.Text;

            while ((line = R.ReadLine()) != null)
            {
                int stringStartPos = line.IndexOf('#');
                if (cari.Equals(line.Substring(0, stringStartPos)))
                {
                    find = true;
                    strArray = line.Split(new string[] { "#" }, StringSplitOptions.None);
                    MessageBox.Show("Data Found");
                    tbox_idcustomer.Text = strArray[0];
                    tbox_name.Text = strArray[1];
                    tbox_gender.Text = strArray[2];
                    tbox_idtype.Text = strArray[3];
                    tbox_idnumber.Text = strArray[4];
                    tbox_birthdate.Text = strArray[5];
                    tbox_address.Text = strArray[6];
                    dataGridView1[0, 0].Value = strArray[0];
                    dataGridView1[1, 0].Value = strArray[1];
                    dataGridView1[2, 0].Value = strArray[2];
                    dataGridView1[3, 0].Value = strArray[3];
                    dataGridView1[4, 0].Value = strArray[4];
                    dataGridView1[5, 0].Value = strArray[5];
                    dataGridView1[6, 0].Value = strArray[6];
                }
            }
            if (!find)
            {
                MessageBox.Show("Sorry, Data Not Found");
            }

            R.Close();
            F.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbox_idcustomer.Text = "";
            tbox_idnumber.Text = "";
            tbox_name.Text = "";
            tbox_address.Text = "";
            tbox_idnumber.Text = "";
            tbox_idtype.Text = "";
            tbox_gender.Text = "";
            tbox_birthdate.Text = "";
            tbox_search.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string line, cari;
            string[] strArray = new string[7];
            Boolean find = false;
            FileStream F;
            StreamReader R;


            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Rows.Clear();
            //dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "ID Customer";
            dataGridView1.Columns[1].Name = "Full Name";
            dataGridView1.Columns[2].Name = "Gender";
            dataGridView1.Columns[3].Name = "ID Type";
            dataGridView1.Columns[4].Name = "Type Number";
            dataGridView1.Columns[5].Name = "Birthdate";
            dataGridView1.Columns[6].Name = "Address";
            F = new FileStream("Customer.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            cari = tbox_search.Text;

            while ((line = R.ReadLine()) != null)
            {
                int stringStartPos = line.IndexOf('#');
                string cari2 = line.Substring(0, stringStartPos);
                if (cari2.Contains(cari))
                {
                    RefreshDataGrid();
                    find = true;
                    strArray = line.Split(new string[] { "#" }, StringSplitOptions.None);
                    MessageBox.Show("Data Found");
                    dataGridView1[0, 0].Value = strArray[0];
                    dataGridView1[1, 0].Value = strArray[1];
                    dataGridView1[2, 0].Value = strArray[2];
                    dataGridView1[3, 0].Value = strArray[3];
                    dataGridView1[4, 0].Value = strArray[4];
                    dataGridView1[5, 0].Value = strArray[5];
                    dataGridView1[6, 0].Value = strArray[6];
                    
                }
            }
            if (!find)
            {
                MessageBox.Show("Sorry, Data Not Found");
            }
            R.Close();
            F.Close();
        }//

        
        

    }
}
