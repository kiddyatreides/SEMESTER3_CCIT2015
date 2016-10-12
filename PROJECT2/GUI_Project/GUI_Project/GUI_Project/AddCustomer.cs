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
    public partial class AddCustomer : Form
    {
        FileStream F;
        StreamReader R;
        StreamWriter W;

        public AddCustomer()
        {
            InitializeComponent();
        }

        public string newCustomerCode()
        {
            string Str, CustomerCode;
            int AirplaneInt;
            string[] strArray = new string[7];
            try
            {
                if (new FileInfo("Airplane.txt").Length == 0)
                {
                    CustomerCode = "C001";
                    return CustomerCode;
                }
                else
                {
                    Str = System.IO.File.ReadLines("Customer.txt").Last();
                    strArray = Str.Split(new string[] { "#" }, StringSplitOptions.None);
                    CustomerCode = strArray[0].Substring(1, 3);
                    AirplaneInt = Convert.ToInt32(CustomerCode) + 1;
                    if (AirplaneInt <= 9)
                    {
                        CustomerCode = "C00" + AirplaneInt.ToString();
                    }
                    else if (AirplaneInt <= 99)
                    {
                        CustomerCode = "C0" + AirplaneInt.ToString();
                    }
                    else if (AirplaneInt <= 999)
                    {
                        CustomerCode = "C" + AirplaneInt.ToString();
                    }
                    return CustomerCode;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Data, Creating File.....");
                CustomerCode = "C001";
                return CustomerCode;
            }
        }//

        private int ValidateData()
        {
            int flag = 0;
            if (tbox_name.Text == "")
            {
                tbox_name.Focus();
                error_addcustomer.SetError(tbox_name, "Please Fill in The First Name");
                flag = 1;
            }
            try
            {
                if (radio_male.Checked || radio_female.Checked)
                {
                    flag = 0;
                }
                else
                {
                        radio_male.Focus();
                        radio_female.Focus();
                        error_addcustomer.SetError(radio_male, "Please Choose Gender");
                        error_addcustomer.SetError(radio_female, "Please Choose Gender");
                        flag = 1;
                }
            }
            catch(FormatException)
            {
                error_addcustomer.SetError(radio_male, "Please Choose Gender");
                error_addcustomer.SetError(radio_female, "Please Choose Gender");
            }
            if (cbox_idtype.Text == "")
            {
                cbox_idtype.Focus();
                error_addcustomer.SetError(cbox_idtype, "Please Choose The ID Type");
                flag = 1;
            }
            if (tbox_idnumber.Text == "")
            {
                tbox_idnumber.Focus();
                error_addcustomer.SetError(tbox_idnumber, "Please Fill in The ID Number");
                flag = 1;
            }
            if (datetime_birthdate.Value.Year > 1999 )
            {
                datetime_birthdate.Focus();
                error_addcustomer.SetError(datetime_birthdate, "You Must 17th to Register");
                flag = 1;
            }
            if (tbox_address.Text == "")
            {
                tbox_address.Focus();
                error_addcustomer.SetError(tbox_address, "Please Fill in The Address");
                flag = 1;
            }
            return flag;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            tbox_idcustomer.Text = newCustomerCode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                string IDCostumer, Name, IDType, IDNumber, Gender, Address, Birthdate;
                try
                {

                    F = new FileStream("Customer.txt", FileMode.Append, FileAccess.Write);
                    W = new StreamWriter(F);

                    IDCostumer = tbox_idcustomer.Text;
                    Name = tbox_name.Text;
                    IDType = cbox_idtype.SelectedItem.ToString();
                    if (radio_male.Checked)
                    {
                        Gender = "Male";
                    }
                    else
                    {
                        Gender = "Female";
                    }
                    Birthdate = datetime_birthdate.Value.ToShortDateString();
                    IDNumber = tbox_idnumber.Text;
                    Address = tbox_address.Text;

                    W.WriteLine(IDCostumer + "#" + Name + "#" + Gender + "#" + IDType + "#" + IDNumber + "#" + Birthdate + "#" + Address);
                    W.Flush();
                    W.Close();
                    F.Close();
                    MessageBox.Show("Data Has Been Succesfully Saved");
                    tbox_idcustomer.Text = newCustomerCode();
                    error_addcustomer.Clear();
                    clear();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    error_addcustomer.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Correct The Field");
            }
        }//

        public void clear()
        {
            tbox_name.Text = "";
            tbox_address.Text = "";
            tbox_idnumber.Text = "";
            cbox_idtype.Text = "";
            radio_male.Checked = false;
            radio_female.Checked = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
