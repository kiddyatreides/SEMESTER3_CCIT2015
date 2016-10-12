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
    public partial class DisplayTicket : Form
    {
        public DisplayTicket()
        {
            InitializeComponent();
        }


        public void RefreshDataGrid()
        {
            FileStream F;
            StreamReader R;
            string str;
            int row = 0;
            F = new FileStream("Ticket.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            dataGridView1.ColumnCount = 14;
            dataGridView1.Columns[0].Name = "ID Ticket";
            dataGridView1.Columns[1].Name = "ID Customer";
            dataGridView1.Columns[2].Name = "Customer Name";
            dataGridView1.Columns[3].Name = "Gender";
            dataGridView1.Columns[4].Name = "ID Flight";
            dataGridView1.Columns[5].Name = "Departure";
            dataGridView1.Columns[6].Name = "Arrival";
            dataGridView1.Columns[7].Name = "Departure Date";
            dataGridView1.Columns[8].Name = "Departure Time";
            dataGridView1.Columns[9].Name = "Arrival Date";
            dataGridView1.Columns[10].Name = "Arrival Time";
            dataGridView1.Columns[11].Name = "Date Time Buy";
            dataGridView1.Columns[12].Name = "Quantity";
            dataGridView1.Columns[13].Name = "Total";
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

        private void DisplayTicket_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string line = "";
            int row = 0;
            Boolean find;

            FileStream fs = new FileStream("Ticket.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while ((line = sr.ReadLine()) != null)
            {

                if (line.Contains(tbox_search.Text))
                {
                    MessageBox.Show("Data Found");
                    find = true;
                    string[] strArray = line.Split(new string[] { "#" }, StringSplitOptions.None);
                    //MessageBox.Show("Data Found");
                    string[] elemen = line.Split('#');

                    tbox_idticket.Text = elemen[0];
                    tbox_idcustomer.Text = elemen[1];
                    tbox_name.Text = elemen[2];
                    tbox_gender.Text = elemen[3];
                    tbox_idflight.Text = elemen[4];
                    tbox_departure.Text = elemen[5];
                    tbox_arrival.Text = elemen[6];
                    tbox_departuredate.Text = elemen[7];
                    tbox_departuretime.Text = elemen[8];
                    tbox_arrivaldate.Text = elemen[9];
                    tbox_arrivaltime.Text = elemen[10];
                    tbox_date.Text = elemen[11];
                    textBox1.Text = elemen[12];
                    tbox_total.Text = elemen[13];
                    /*isicombo();
                    category.SelectedText = elemen[4];
                    releaseyear.Text = elemen[5];
                    stock.Text = elemen[6];*/
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add();
                    dataGridView1[0, 0].Value = elemen[0];
                    dataGridView1[1, 0].Value = elemen[1];
                    dataGridView1[2, 0].Value = elemen[2];
                    dataGridView1[3, 0].Value = elemen[3];
                    dataGridView1[4, 0].Value = elemen[4];
                    dataGridView1[5, 0].Value = elemen[5];
                    dataGridView1[6, 0].Value = elemen[6];
                    dataGridView1[7, 0].Value = elemen[7];
                    dataGridView1[8, 0].Value = elemen[8];
                    dataGridView1[9, 0].Value = elemen[9];
                    dataGridView1[10, 0].Value = elemen[10];
                    dataGridView1[11, 0].Value = elemen[11];
                    dataGridView1[12, 0].Value = elemen[12];
                    dataGridView1[13, 0].Value = elemen[13];





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

    }
}
