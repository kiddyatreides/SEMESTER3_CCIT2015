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
    public partial class AddTicket : Form
    {
        public AddTicket()
        {
            InitializeComponent();
        }

        public void clear()
        {
            numeric_quantity.Value = 0;
            tbox_total.Text = "";
            tbox_idflight.Text = "";
            tbx_idairplane.Text = "";
            tbox_departure.Text = "";
            tbox_departuredate.Text = "";
            tbox_departuretime.Text = "";
            tbox_arrival.Text = "";
            tbox_arrivaldate.Text = "";
            tbox_arrivaltime.Text = "";
            tbox_stock.Text = "";
            tbox_price.Text = "";
            tbox_idcustomer.Text = "";
            tbox_name.Text = "";
            tbox_gender.Text = "";
            tbox_idtype.Text = "";
            tbox_idnumber.Text = "";
            tbox_birthdate.Text = "";
            tbox_address.Text = "";
        }

        private int ValidateData()
        {
            int flag = 0;
            if (tbox_idflight.Text == "")
            {
                tbox_idflight.Focus();
                errorProvider1.SetError(tbox_idflight, "Please Fill in The ID Flight and Check it");
                flag = 1;
            }
            if (tbox_idcustomer.Text == "")
            {
                tbox_idcustomer.Focus();
                errorProvider1.SetError(tbox_idcustomer, "Please Fill in The ID Customer and Check it");
                flag = 1;
            }
            if (numeric_quantity.Value == 0)
            {
                numeric_quantity.Focus();
                errorProvider1.SetError(numeric_quantity, "Please Fill The TIcket Quantity");
                flag = 1;
            }
            return flag;
        }

        public string newTicketCode()
        {
            string Str, TicketCode;
            int AirplaneInt;
            string[] strArray = new string[7];
            try
            {
                if (new FileInfo("Ticket.txt").Length == 0)
                {
                    TicketCode = "T001";
                    return TicketCode;
                }
                else
                {
                    Str = System.IO.File.ReadLines("Ticket.txt").Last();
                    strArray = Str.Split(new string[] { "#" }, StringSplitOptions.None);
                    TicketCode = strArray[0].Substring(1, 3);
                    AirplaneInt = Convert.ToInt32(TicketCode) + 1;
                    if (AirplaneInt <= 9)
                    {
                        TicketCode = "T00" + AirplaneInt.ToString();
                    }
                    else if (AirplaneInt <= 99)
                    {
                        TicketCode = "T0" + AirplaneInt.ToString();
                    }
                    else if (AirplaneInt <= 999)
                    {
                        TicketCode = "T" + AirplaneInt.ToString();
                    }
                    return TicketCode;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Data, Creating File.....");
                TicketCode = "T001";
                return TicketCode;
            }
        }

        private void AddTicket_Load(object sender, EventArgs e)
        {
            tbox_idticket.Text = newTicketCode();
            DateTime datenow = DateTime.Now;
            tbox_date.Text = Convert.ToString(datenow);
        }

        private void btn_checkidflight_Click(object sender, EventArgs e)
        {
            string line, cari;
            string[] strArray = new string[4];
            Boolean find = false;
            FileStream F;
            StreamReader R;
      
         
            F = new FileStream("Flight.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            cari = tbox_idflight.Text;

            while ((line = R.ReadLine()) != null)
            {
                int stringStartPos = line.IndexOf('#');
                if (cari.Equals(line.Substring(0, stringStartPos)))
                {
                    find = true;
                    strArray = line.Split(new string[] { "#" }, StringSplitOptions.None);
                    tbox_idflight.Text = strArray[0];
                    tbx_idairplane.Text = strArray[1];
                    tbox_departure.Text = strArray[2];
                    tbox_arrival.Text = strArray[3];
                    tbox_departuredate.Text = strArray[4];
                    tbox_departuretime.Text = strArray[5];
                    tbox_arrivaldate.Text = strArray[6];
                    tbox_arrivaltime.Text = strArray[7];
                    tbox_stock.Text = strArray[8];
                    tbox_price.Text = strArray[9];
                    
                }
            }
            if (!find)
            {
                MessageBox.Show("Sorry, Data Not Found");
            }

            R.Close();
            F.Close();
        }

        private void btn_checkidcustomer_Click(object sender, EventArgs e)
        {
            string line, cari;
            string[] strArray = new string[7];
            Boolean find = false;
            FileStream F;
            StreamReader R;
            F = new FileStream("Customer.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            cari = tbox_idcustomer.Text;

            while ((line = R.ReadLine()) != null)
            {
                int stringStartPos = line.IndexOf('#');
                if (cari.Equals(line.Substring(0, stringStartPos)))
                {
                    find = true;
                    strArray = line.Split(new string[] { "#" }, StringSplitOptions.None);
                    //MessageBox.Show("Data Found");
                    tbox_idcustomer.Text = strArray[0];
                    tbox_name.Text = strArray[1];
                    tbox_gender.Text = strArray[2];
                    tbox_idtype.Text = strArray[3];
                    tbox_idnumber.Text = strArray[4];
                    tbox_birthdate.Text = strArray[5];
                    tbox_address.Text = strArray[6];
                    
                }
            }
            if (!find)
            {
                MessageBox.Show("Sorry, Data Not Found");
            }

            R.Close();
            F.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {

                string idticket, idflight, idcustomer, datetime;
                string name, gender;
                string idflight2, idairplane, departure, arrival, datedeparture, timedeparture, datearrival, timearrival, ticketstock2, price2;
                int quantity, total, price, ticketstock, leftstock, realleftstock;
                try
                {
                    //error_addflight.Clear();
                    FileStream F, F1;
                    StreamReader R, R1;
                    StreamWriter W, W1;

                    // for update flight
                    string cari, Str;
                    string[] strArray = new string[10];
                    Boolean find = false;
                    int Pos;
                    string alltext = "";
                    string txtsimpan = "";
                    //

                    F = new FileStream("Ticket.txt", FileMode.Append, FileAccess.Write);
                    W = new StreamWriter(F);
                    F1 = new FileStream("Flight.txt", FileMode.Open, FileAccess.Read);
                    R1 = new StreamReader(F1);


                    //ticket
                    idticket = tbox_idticket.Text;
                    idflight = tbox_idflight.Text;
                    idcustomer = tbox_idcustomer.Text;
                    datetime = tbox_date.Text;
                    name = tbox_name.Text;
                    gender = tbox_gender.Text;
                    quantity = Convert.ToInt32(numeric_quantity.Value.ToString());
                    price = Convert.ToInt32(tbox_price.Text);
                    total = price * quantity;
                    ticketstock = Convert.ToInt32(tbox_stock.Text);
                    tbox_total.Text = Convert.ToString(total);
                    leftstock = ticketstock - quantity;
                    //
                    //flight
                    idflight = tbox_idflight.Text;//
                    idairplane = tbx_idairplane.Text;//
                    departure = tbox_departure.Text;//
                    arrival = tbox_arrival.Text;//
                    datedeparture = tbox_departuredate.Text;//
                    timedeparture = tbox_departuretime.Text;//
                    datearrival = tbox_arrivaldate.Text;//
                    timearrival = tbox_arrivaltime.Text;//
                    ticketstock2 = leftstock.ToString();//
                    price2 = tbox_price.Text;//

                    cari = tbox_idflight.Text;

                    while ((Str = R1.ReadLine()) != null)
                    {
                        Pos = Str.IndexOf("#");
                        String Chkstr1 = Str.Substring(0, Pos);
                        if ((cari.CompareTo(Chkstr1) == 0))
                        {
                            string[] elemen = Str.Split('#');
                            find = true;
                            elemen[0] = tbox_idflight.Text;
                            elemen[1] = tbx_idairplane.Text;
                            elemen[2] = tbox_departure.Text;
                            elemen[3] = tbox_arrival.Text;
                            elemen[4] = tbox_departuredate.Text;
                            elemen[5] = tbox_departuretime.Text;
                            elemen[6] = tbox_arrivaldate.Text;
                            elemen[7] = tbox_arrivaltime.Text;
                            elemen[8] = leftstock.ToString();
                            elemen[9] = tbox_price.Text;
                            txtsimpan = elemen[0] + "#" + elemen[1] + "#" + elemen[2] + "#" + elemen[3] + "#" + elemen[4] + "#" + elemen[5] + "#" + elemen[6] + "#" + elemen[7] + "#" + elemen[8] + "#" + elemen[9] + "\n";
                            alltext += txtsimpan;
                            //MessageBox.Show("Data Has Been Updated");
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
                    F1.Close();
                    R1.Close();
                    File.WriteAllText("Flight.txt", alltext);
                    //

                    W.WriteLine(idticket + "#" + idcustomer + "#" + name + "#" + gender + "#" + idflight + "#" + departure + "#" + arrival + "#" + datedeparture + "#" + timedeparture + "#" + datearrival + "#" + timearrival +"#" + datetime + "#" + quantity + "#" + total);
                    W.Flush();
                    W.Close();
                    F.Close();
                    MessageBox.Show("Data Sucessfull Added");
                    clear();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    errorProvider1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Correct The Error");
            }
        }

        private void tbox_total_Click(object sender, EventArgs e)
        {
            int quantity, total, price, ticketstock, leftstock;

            quantity = Convert.ToInt32(numeric_quantity.Value.ToString());
            price = Convert.ToInt32(tbox_price.Text);
            total = price * quantity;
            ticketstock = Convert.ToInt32(tbox_stock.Text);
            tbox_total.Text = Convert.ToString(total);
            leftstock = ticketstock - quantity;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        


    }
}
