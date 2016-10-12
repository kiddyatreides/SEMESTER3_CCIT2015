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
    public partial class DisplayAirplane : Form
    {
        public DisplayAirplane()
        {
            InitializeComponent();
        }



        private void DisplayAirplane_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }


        public void RefreshDataGrid()
        {
            FileStream F;
            StreamReader R;
            string str;
            int row = 0;
            F = new FileStream("Airplane.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID Airplane";
            dataGridView1.Columns[1].Name = "Airplane Name";
            dataGridView1.Columns[2].Name = "Type";
            dataGridView1.Columns[3].Name = "Total Seat";
            dataGridView1.Columns[4].Name = "Status";


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

        private void btn_search_Click(object sender, EventArgs e)
        {
            string line, cari;
            string[] strArray = new string[4];
            Boolean find = false;
            FileStream F;
            StreamReader R;


            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Rows.Clear();
            //dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID Airplane";
            dataGridView1.Columns[1].Name = "Airplane Name";
            dataGridView1.Columns[2].Name = "Type";
            dataGridView1.Columns[3].Name = "Total Seat";
            dataGridView1.Columns[4].Name = "Status";
            F = new FileStream("Airplane.txt", FileMode.Open, FileAccess.Read);
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
                    tbox_idairplane.Text = strArray[0];
                    tbox_name.Text = strArray[1];
                    tbox_type.Text = strArray[2];
                    tbox_totalseat.Text = strArray[3];
                    tbox_status.Text = strArray[4];
                    dataGridView1[0, 0].Value = strArray[0];
                    dataGridView1[1, 0].Value = strArray[1];
                    dataGridView1[2, 0].Value = strArray[2];
                    dataGridView1[3, 0].Value = strArray[3];
                    dataGridView1[4, 0].Value = strArray[4];
                }  
            }
            if (!find)
            {
                MessageBox.Show("Sorry, Data Not Found");
            }
            
            R.Close();
            F.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        public void clear()
        {
            tbox_idairplane.Text = "";
            tbox_name.Text = "";
            tbox_type.Text = "";
            tbox_totalseat.Text = "";
        }

        public void refreshDataGrid()
        {
            string Str;
            int row = 0;
            FileStream F;
            StreamReader R;

            try
            {
                F = new FileStream("Airplane.txt", FileMode.Open, FileAccess.Read);
                R = new StreamReader(F);

                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "ID Airplane";
                dataGridView1.Columns[1].Name = "Airplane Name";
                dataGridView1.Columns[2].Name = "Type";
                dataGridView1.Columns[3].Name = "Total Seat";
                dataGridView1.Columns[4].Name = "Status";
                

                while ((Str = R.ReadLine()) != null)
                {
                    dataGridView1.Rows.Add();
                    string[] s = Str.Split('#');
                    for (int i = 0; i <= s.Count() - 1; i++)
                    {
                        dataGridView1[i, row].Value = s[i];
                    }
                    row++;
                }
                R.Close();
                F.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No One Registered Yet");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
        }
    }
}
        /*private void btn_delete_Click(object sender, EventArgs e)
        {
            string StrCari, line;
            ArrayList databaru;
            FileStream F;
            StreamReader R;

            dataGridView1.Rows.Clear();


            F = new FileStream("Airplane.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            StrCari = tbox_idairplane.Text;
            DialogResult result = MessageBox.Show("Are You Sure To Delete The Data", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result.ToString().Equals("Yes"))
            {
                databaru = new ArrayList();
                while ((line = R.ReadLine()) != null)
                {
                    if (!line.Equals(StrCari))
                    {
                        databaru.Add(line);
                    }
                    line = R.ReadLine();
                }
                MessageBox.Show("Data Deleted", "Notification", MessageBoxButtons.OK);
                clear();
                R.Close();
                F.Close();
                File.WriteAllLines("Airplane.txt", databaru.ToArray(typeof(string)) as string[]);
            }
            else
            {
                MessageBox.Show("Data Deletion Aborted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            R.Close();
            F.Close();
            refreshDataGrid();
        }*/
    
