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
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
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
            string line = "";
            int row = 0;
            Boolean find;

            FileStream fs = new FileStream("Customer.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while ((line = sr.ReadLine()) != null)
            {
                
                if (line.Contains(textBox1.Text))
                {
                    MessageBox.Show("Data Found");
                    find = true;
                    string[] strArray = line.Split(new string[] { "#" }, StringSplitOptions.None);
                    //MessageBox.Show("Data Found");
                    string[] elemen = line.Split('#');

                    tbox_idcustomer.Text = elemen[0];
                    tbox_name.Text = elemen[1];
                    tbox_gender.Text = elemen[2];
                    tbox_address.Text = elemen[3];
                    tbox_idtype.Text = elemen[4];
                    tbox_idnumber.Text = elemen[5];
                    tbox_birthdate.Text = elemen[6];
                    /*isicombo();
                    category.SelectedText = elemen[4];
                    releaseyear.Text = elemen[5];
                    stock.Text = elemen[6];*/
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add();
                    /*dataGridView1[0, 0].Value = elemen[0];
                    dataGridView1[1, 0].Value = elemen[1];
                    dataGridView1[2, 0].Value = elemen[2];
                    dataGridView1[3, 0].Value = elemen[3];
                    dataGridView1[4, 0].Value = elemen[4];
                    dataGridView1[5, 0].Value = elemen[5];
                    dataGridView1[6, 0].Value = elemen[6];*/

                    

                    

                    /*for (int i = 0; i < elemen.Count() - 1; i++)
                    {
                      dataGridView1[i, row].Value = elemen[i];
                    }*/
                    row++;
                }
            }
            /*if (!find)
            {
                MessageBox.Show("Data not Found");
                isiDataGridView();
            }*/
            fs.Close();
            sr.Close();
        }
    

        private void Testing_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
    }
}
