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
    public partial class Add_flight : Form
    {
        public Add_flight()
        {
            InitializeComponent();
        }

        private void Add_flight_Load(object sender, EventArgs e)
        {
            tbox_idflight.Text = newFlightCode();
            isiCombo();
        }

        public string newFlightCode()
        {
            string Str, FlightCode;
            int AirplaneInt;
            string[] strArray = new string[7];
            try
            {
                if (new FileInfo("Flight.txt").Length == 0)
                {
                    FlightCode = "F001";
                    return FlightCode;
                }
                else
                {
                    Str = System.IO.File.ReadLines("Flight.txt").Last();
                    strArray = Str.Split(new string[] { "#" }, StringSplitOptions.None);
                    FlightCode = strArray[0].Substring(1, 3);
                    AirplaneInt = Convert.ToInt32(FlightCode) + 1;
                    if (AirplaneInt <= 9)
                    {
                        FlightCode = "F00" + AirplaneInt.ToString();
                    }
                    else if (AirplaneInt <= 99)
                    {
                        FlightCode = "F0" + AirplaneInt.ToString();
                    }
                    else if (AirplaneInt <= 999)
                    {
                        FlightCode = "F" + AirplaneInt.ToString();
                    }
                    return FlightCode;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Data, Creating File.....");
                FlightCode = "F001";
                return FlightCode;
            }
        }//

        public void isiCombo()
        {
            string[] lineofcontents = File.ReadAllLines("Airplane.txt");
            foreach (var line in lineofcontents)
            {
                string[] tokens = line.Split('#');
                cbox_idairplane.Items.Add(tokens[0]);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                string idflight, idairplane, departure, arrival, datedeparture, timedeparture, datearrival, timearrival, ticketstock, price;
                try
                {
                    error_addflight.Clear();
                    FileStream F;
                    StreamWriter W;

                    F = new FileStream("Flight.txt", FileMode.Append, FileAccess.Write);
                    W = new StreamWriter(F);

                    idflight = tbox_idflight.Text;
                    idairplane = cbox_idairplane.SelectedItem.ToString();
                    departure = tbox_departure.Text;
                    arrival = tbox_arrival.Text;
                    datedeparture = datetime_datedeparture.Value.ToShortDateString();
                    timedeparture = tbox_timedeparture.Text;
                    datearrival = datetime_datearrival.Value.ToShortDateString();
                    timearrival = tbox_timearrival.Text;
                    ticketstock = numeric_ticketstock.Value.ToString();
                    price = tbox_price.Text;

                    W.WriteLine(idflight + "#" + idairplane + "#" + departure + "#" + arrival + "#" + datedeparture + "#" + timedeparture + "#" + datearrival + "#" + timearrival + "#" + ticketstock + "#" + price + "#");
                    W.Flush();
                    W.Close();
                    MessageBox.Show("Data Sucessfull Added");
                    //RefreshDataGrid();
                    clear();
                    tbox_idflight.Text = newFlightCode();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    error_addflight.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Correct The Error Above!");
            }
        }//

        public void clear()
        {
            cbox_idairplane.Text = "";
            tbox_departure.Text = "Jakarta";
            tbox_arrival.Text = "";
            datetime_datedeparture.Value = DateTime.Now;
            datetime_datearrival.Value = DateTime.Now;
            tbox_timedeparture.Text = "";
            tbox_timearrival.Text = "";
            numeric_ticketstock.Value = 0;
            tbox_price.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private int ValidateData()
        {
            int flag = 0;
            if (cbox_idairplane.Text == "")
            {
                cbox_idairplane.Focus();
                error_addflight.SetError(cbox_idairplane, "Please Fill in The First Name");
                flag = 1;
            }
            if (tbox_arrival.Text == "")
            {
                tbox_arrival.Focus();
                error_addflight.SetError(tbox_arrival, "Please Fill in The Type");
                flag = 1;
            }
            if (numeric_ticketstock.Value < 50 || numeric_ticketstock.Value > 500)
            {
                numeric_ticketstock.Focus();
                error_addflight.SetError(numeric_ticketstock, "Ticket must be above 50 and bellow 200");
                flag = 1;
            }
            if (tbox_timedeparture.Text == "")
            {
                tbox_timedeparture.Focus();
                error_addflight.SetError(tbox_timedeparture, "Please Fill in The Time");
                flag = 1;
            }
            if (tbox_timearrival.Text == "")
            {
                tbox_timearrival.Focus();
                error_addflight.SetError(tbox_timearrival, "Please Fill in The Time");
                flag = 1;
            }
            if (tbox_price.Text == "")
            {
                tbox_price.Focus();
                error_addflight.SetError(tbox_price, "Please Fill in The Time");
                flag = 1;
            }
            if (datetime_datedeparture.Value < DateTime.Now)
            {
                datetime_datedeparture.Focus();
                error_addflight.SetError(datetime_datedeparture, "Please Fill in The Correct Date");
                flag = 1;
            }
            if (datetime_datearrival.Value < DateTime.Now)
            {
                datetime_datearrival.Focus();
                error_addflight.SetError(datetime_datearrival, "Please Fill in The Correct Date");
                flag = 1;
            }
            return flag;
        }
    }
}
