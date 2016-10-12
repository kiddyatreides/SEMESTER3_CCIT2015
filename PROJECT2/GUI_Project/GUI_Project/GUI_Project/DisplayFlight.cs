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
    public partial class DisplayFlight : Form
    {
        public DisplayFlight()
        {
            InitializeComponent();
        }

        public void RefreshDataGrid()
        {
            FileStream F;
            StreamReader R;
            string str;
            int row = 0;
            F = new FileStream("Flight.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "ID Flight";
            dataGridView1.Columns[1].Name = "ID Airplane";
            dataGridView1.Columns[2].Name = "Departure";
            dataGridView1.Columns[3].Name = "Arrival";
            dataGridView1.Columns[4].Name = "Departure Date";
            dataGridView1.Columns[5].Name = "Departure Time";
            dataGridView1.Columns[6].Name = "Arrival Date";
            dataGridView1.Columns[7].Name = "Arrival Time";
            dataGridView1.Columns[8].Name = "Ticket Stock";
            dataGridView1.Columns[9].Name = "Price";
            


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

        private void DisplayFlight_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string line, cari;
            string[] strArray = new string[10];
            Boolean find = false;
            FileStream F;
            StreamReader R;
            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Rows.Clear();
            //dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "ID Flight";
            dataGridView1.Columns[1].Name = "ID Airplane";
            dataGridView1.Columns[2].Name = "Departure";
            dataGridView1.Columns[3].Name = "Arrival";
            dataGridView1.Columns[4].Name = "Departure Date";
            dataGridView1.Columns[5].Name = "Departure Time";
            dataGridView1.Columns[6].Name = "Arrival Date";
            dataGridView1.Columns[7].Name = "Arrival Time";
            dataGridView1.Columns[8].Name = "Ticket Stock";
            dataGridView1.Columns[9].Name = "Price";
            F = new FileStream("Flight.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            cari = tbox_search.Text;

            while ((line = R.ReadLine()) != null)
            {
                int stringStartPos = line.IndexOf('#');
                if (cari.Equals(line.Substring(0, stringStartPos)))
                {
                    find = true;
                    strArray = line.Split(new string[] { "#" }, StringSplitOptions.None);
                    //MessageBox.Show("Data Found");
                    tbox_idflight.Text = strArray[0];
                    tbox_idairplane.Text = strArray[1];
                    tbox_departure.Text = strArray[2];
                    tbox_arrival.Text = strArray[3];
                    tbox_departuredate.Text = strArray[4];
                    tbox_departuretime.Text = strArray[5];
                    tbox_arrivaldate.Text = strArray[6];
                    tbox_arrivaltime.Text = strArray[7];
                    tbox_ticketstock.Text = strArray[8];
                    tbox_price.Text = strArray[9];
                    dataGridView1[0, 0].Value = strArray[0];
                    dataGridView1[1, 0].Value = strArray[1];
                    dataGridView1[2, 0].Value = strArray[2];
                    dataGridView1[3, 0].Value = strArray[3];
                    dataGridView1[4, 0].Value = strArray[4];
                    dataGridView1[5, 0].Value = strArray[5];
                    dataGridView1[6, 0].Value = strArray[6];
                    dataGridView1[7, 0].Value = strArray[7];
                    dataGridView1[8, 0].Value = strArray[8];
                    dataGridView1[9, 0].Value = strArray[9];
                }
            }
            if (!find)
            {
                MessageBox.Show("Sorry, Data Not Found");
            }

            R.Close();
            F.Close();
        }
    }
}
