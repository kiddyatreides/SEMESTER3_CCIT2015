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
    public partial class Add_airplane : Form
    {

        FileStream F;
        StreamReader R;
        StreamWriter W;

        public Add_airplane()
        {
            InitializeComponent();
        }

        public string newAirplaneCode()
        {
            string Str, AirplaneCode;
            int AirplaneInt;
            string[] strArray = new string[7];
            try
            {
                if (new FileInfo("Airplane.txt").Length == 0)
                {
                    AirplaneCode = "A001";
                    return AirplaneCode;
                }
                else
                {
                    Str = System.IO.File.ReadLines("Airplane.txt").Last();
                    strArray = Str.Split(new string[] { "#" }, StringSplitOptions.None);
                    AirplaneCode = strArray[0].Substring(1, 3);
                    AirplaneInt = Convert.ToInt32(AirplaneCode) + 1;
                    if (AirplaneInt <= 9)
                    {
                        AirplaneCode = "A00" + AirplaneInt.ToString();
                    }
                    else if (AirplaneInt <= 99)
                    {
                        AirplaneCode = "A0" + AirplaneInt.ToString();
                    }
                    else if (AirplaneInt <= 999)
                    {
                        AirplaneCode = "A" + AirplaneInt.ToString();
                    }
                    return AirplaneCode;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Data, Creating File.....");
                AirplaneCode = "A001";
                return AirplaneCode;
            }
        }//

        private void Add_airplane_Load(object sender, EventArgs e)
        {
            tbox_idairplane.Text = newAirplaneCode();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                error_addairplane.Clear();
                string IDAirplane, Name, Type, TotalSeat, Status;
                try
                {

                    F = new FileStream("Airplane.txt", FileMode.Append, FileAccess.Write);
                    W = new StreamWriter(F);

                    IDAirplane = tbox_idairplane.Text;
                    Name = tbox_nameairplane.Text;
                    Type = cbox_typeairplane.SelectedItem.ToString();
                    TotalSeat = numeric_totalseat.Value.ToString();
                    Status = "Active";
                    

                    W.WriteLine(IDAirplane + "#" + Name + "#" + Type + "#" + TotalSeat + "#" + Status);
                    W.Flush();
                    W.Close();
                    F.Close();
                    MessageBox.Show("Data Has Been Succesfully Saved");
                    //refreshDataGrid();
                    //refreshControl();
                    tbox_idairplane.Text = newAirplaneCode();
                    clear();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    error_addairplane.Clear();
                }
            } //
            else if (ValidateData() == 1)
            {
                MessageBox.Show("Please Correct The Error Above!");
            }
        }


        private int ValidateData()
        {
            int flag = 0;
            if (tbox_nameairplane.Text == "")
            {
                tbox_nameairplane.Focus();
                error_addairplane.SetError(tbox_nameairplane, "Please Fill in The First Name");
                flag = 1;
            }
            if (cbox_typeairplane.Text == "")
            {
                cbox_typeairplane.Focus();
                error_addairplane.SetError(cbox_typeairplane, "Please Fill in The Type");
                flag = 1;
            }
            if (numeric_totalseat.Value < 50 || numeric_totalseat.Value > 500)
            {
                numeric_totalseat.Focus();
                error_addairplane.SetError(numeric_totalseat, "Please Fill The Correct Seat");
                flag = 1;
            }
            return flag;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            tbox_nameairplane.Text = "";
            cbox_typeairplane.Text = "";
            numeric_totalseat.Value = 0;
        }

        




    }
}
