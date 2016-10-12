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
    public partial class UpdateFlight : Form
    {
        public UpdateFlight()
        {
            InitializeComponent();
        }

        public void isiCombo()
        {
            string[] lineofcontents = File.ReadAllLines("Airplane.txt");
            foreach (var line in lineofcontents)
            {
                string[] tokens = line.Split('#');
                cbox_idairplane.Items.Add(tokens[0]);
            }
        }

        private int ValidateData()
        {
            int flag = 0;
            if (cbox_idairplane.Text == "")
            {
                cbox_idairplane.Focus();
                error_updateflight.SetError(cbox_idairplane, "Please Fill in The First Name");
                flag = 1;
            }
            if (datetime_departuredate.Value < DateTime.Now)
            {
                datetime_departuredate.Focus();
                error_updateflight.SetError(datetime_departuredate, "Please Fill in The Correct Departure Date");
                flag = 1;
            }
            if (tbox_departuretime.Text == "")
            {
                tbox_departuretime.Focus();
                error_updateflight.SetError(tbox_departuretime, "Please Fill in The Departure Time");
                flag = 1;
            }
            if (tbox_price.Text == "")
            {
                tbox_price.Focus();
                error_updateflight.SetError(tbox_price, "Please Fill in The Price");
                flag = 1;
            }
            if (tbox_arrival.Text == "")
            {
                tbox_arrival.Focus();
                error_updateflight.SetError(tbox_arrival, "Please Fill in The Arrival");
                flag = 1;
            }
            if (datetime_arrivaldate.Value < DateTime.Now)
            {
                datetime_arrivaldate.Focus();
                error_updateflight.SetError(datetime_arrivaldate, "Please Fill in The Correct Arrival Date");
                flag = 1;
            }
            if (tbox_arrivaltime.Text == "")
            {
                tbox_arrivaltime.Focus();
                error_updateflight.SetError(tbox_arrivaltime, "Please Fill in The Time");
                flag = 1;
            }
            if (numeric_ticketstock.Value < 0 || numeric_ticketstock.Value > 200)
            {
                numeric_ticketstock.Focus();
                error_updateflight.SetError(numeric_ticketstock, "Please Fill The Correct Ticket Stock");
                flag = 1;
            }
            return flag;
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            string line, cari;
            string[] strArray = new string[10];
            Boolean find = false;
            FileStream F;
            StreamReader R;
            F = new FileStream("Flight.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            cari = tbox_search.Text;

            while ((line = R.ReadLine()) != null)
            {
                strArray = line.Split(new string[] { "#" }, StringSplitOptions.None);
                int stringStartPos = line.IndexOf('#');
                if (cari.Equals(line.Substring(0, stringStartPos)))
                {
                    find = true;

                    MessageBox.Show("Data Found");
                    tbox_idflight.Text = strArray[0];
                    cbox_idairplane.Text = strArray[1];
                    tbox_departure.Text = strArray[2];
                    tbox_arrival.Text = strArray[3];
                    datetime_departuredate.Text = strArray[4];
                    tbox_departuretime.Text = strArray[5];
                    datetime_arrivaldate.Text = strArray[6];
                    tbox_arrivaltime.Text = strArray[7];
                    numeric_ticketstock.Text = strArray[8];
                    tbox_price.Text = strArray[8];
                }
            }
            if (!find)
            {
                MessageBox.Show("Sorry, Data Not Found");
            }

            R.Close();
            F.Close();
        }

        public void clear()
        {
            tbox_departure.Text = "";
            tbox_search.Text = "";
            tbox_idflight.Text = "";
            cbox_idairplane.Text = "";
            tbox_departuretime.Text = "";
            datetime_departuredate.Value = DateTime.Now;
            numeric_ticketstock.Value = 0;
            tbox_price.Text = "";
            tbox_arrival.Text = "";
            tbox_arrivaltime.Text = "";
            datetime_arrivaldate.Value = DateTime.Now;
        }

        private void UpdateFlight_Load(object sender, EventArgs e)
        {
            isiCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData() == 0)
                {
                    error_updateflight.Clear();
                    try
                    {
                        FileStream F;
                        StreamReader R;
                        string cari, Str;
                        string[] strArray = new string[10];
                        Boolean find = false;
                        int Pos;
                        string alltext = "";
                        string txtsimpan = "";
                        F = new FileStream("Flight.txt", FileMode.Open, FileAccess.Read);
                        R = new StreamReader(F);

                        cari = tbox_search.Text;

                        while ((Str = R.ReadLine()) != null)
                        {
                            Pos = Str.IndexOf("#");
                            String Chkstr1 = Str.Substring(0, Pos);
                            if ((cari.CompareTo(Chkstr1) == 0))
                            {
                                string[] elemen = Str.Split('#');
                                find = true;
                                elemen[0] = tbox_idflight.Text;
                                elemen[1] = cbox_idairplane.Text;
                                elemen[2] = tbox_departure.Text;
                                elemen[3] = tbox_arrival.Text;
                                elemen[4] = datetime_departuredate.Text;
                                elemen[5] = tbox_departuretime.Text;
                                elemen[6] = datetime_arrivaldate.Text;
                                elemen[7] = tbox_arrivaltime.Text;
                                elemen[8] = numeric_ticketstock.Value.ToString();
                                elemen[9] = tbox_price.Text;
                                txtsimpan = elemen[0] + "#" + elemen[1] + "#" + elemen[2] + "#" + elemen[3] + "#" + elemen[4] + "#" + elemen[5] + "#" + elemen[6] + "#" + elemen[7] + "#" + elemen[8] + "#" + elemen[9] + "\n";
                                alltext += txtsimpan;
                                MessageBox.Show("Data Has Been Updated");
                                clear();
                            }
                            else
                            {
                                alltext = alltext + Str + "\n";
                            }
                        }

                        if (!find)
                        {
                            MessageBox.Show("Sorry Data Not Found");
                        }
                        R.Close();
                        F.Close();
                        File.WriteAllText("Flight.txt", alltext);

                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please Correct The Data");
                }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
