using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GUI_Project
{
    public partial class AddFlight : Form
    {
        FileStream F;
        StreamReader R;
        StreamWriter W;

        public string NewFlightCode()
        {
            string Str, FlightCode;
            int BookInt;
            string[] strArray = new string[7];
            if (new FileInfo("Flight.txt").Length == 0)
            {
                FlightCode = "B001";
                return FlightCode;
            }
            else
            {
                Str = System.IO.File.ReadLines("Flight.txt").Last();
                strArray = Str.Split(new string[] { "#" }, StringSplitOptions.None);
                FlightCode = strArray[0].Substring(1, 3);
                BookInt = Convert.ToInt32(FlightCode) + 1;
                if (BookInt <= 9)
                {
                    FlightCode = "F00" + BookInt.ToString();
                }
                else if (BookInt <= 99)
                {
                    FlightCode = "F0" + BookInt.ToString();
                }
                else if (BookInt <= 999)
                {
                    FlightCode = "F" + BookInt.ToString();
                }
                return FlightCode;
            }
        }

        public void isiCombo()
            {
                MessageBox.Show("1");
            string[] lineofcontents = File.ReadAllLines("Airplane.txt");
            foreach (var line in lineofcontents)
            {
                string[] tokens = line.Split('#');
                cbox_idairplane.Items.Add(tokens[0]);
            }
        }


        public AddFlight()
        {
            InitializeComponent();
        }

        private void AddFlight_Load(object sender, EventArgs e)
        {
            tbox_idflight.Text = NewFlightCode();
            isiCombo();
            MessageBox.Show("1");
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string idflight, idairplane, title, departure, arrival, datedeparture, timedeparture, datearrival, timearrival, ticketstock, price;
            try
            {
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
                //RefreshControl();
                tbox_idflight.Text = NewFlightCode();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        
    }
}
