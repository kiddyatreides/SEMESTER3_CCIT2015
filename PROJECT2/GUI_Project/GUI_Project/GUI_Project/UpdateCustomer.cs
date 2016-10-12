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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private int ValidateData()
        {
            int flag = 0;
            if (tbox_name.Text == "")
            {
                tbox_name.Focus();
                error_addcustomer.SetError(tbox_name, "Please Fill in The Full Name");
                flag = 1;
            }
            if (cbox_gender.Text == "")
            {
                cbox_gender.Focus();
                error_addcustomer.SetError(cbox_gender, "Please Choose The Gender");
                flag = 1;
            }
            if (cbox_idtype.Text == "")
            {
                cbox_idtype.Focus();
                error_addcustomer.SetError(cbox_idtype, "Please Choose ID Type");
                flag = 1;
            }
            if (tbox_idnumber.Text == "")
            {
                tbox_idnumber.Focus();
                error_addcustomer.SetError(tbox_idnumber, "Please Fill In The ID Number");
                flag = 1;
            }
            if (datetime_birthdate.Value.Year < 17)
            {
                datetime_birthdate.Focus();
                error_addcustomer.SetError(datetime_birthdate, "You Must 17th To Register");
                flag = 1;
            }
            if (tbox_address.Text == "")
            {
                tbox_address.Focus();
                error_addcustomer.SetError(tbox_address, "Please Fill In The Address");
                flag = 1;
            }
            return flag;
        }

        public void clear()
        {
            tbox_search.Text = "";
            tbox_name.Text = "";
            tbox_idcustomer.Text = "";
            cbox_gender.Text = "";
            cbox_idtype.Text = "";
            tbox_idnumber.Text = "";
            datetime_birthdate.Text = "";
            tbox_address.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line, cari;
            string[] strArray = new string[7];
            Boolean find = false;
            FileStream F;
            StreamReader R;
            F = new FileStream("Customer.txt", FileMode.Open, FileAccess.Read);
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
                    tbox_idcustomer.Text = strArray[0];
                    tbox_name.Text = strArray[1];
                    cbox_gender.Text = strArray[2];
                    cbox_idtype.Text = strArray[3];
                    tbox_idnumber.Text = strArray[4];
                    datetime_birthdate.Text = strArray[5];
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData() == 0)
                {
                    error_addcustomer.Clear();
                    try
                    {
                        FileStream F;
                        StreamReader R;
                        string cari, Str;
                        string[] strArray = new string[7];
                        Boolean find = false;
                        int Pos;
                        string alltext = "";
                        string txtsimpan = "";
                        F = new FileStream("Customer.txt", FileMode.Open, FileAccess.Read);
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
                                elemen[0] = tbox_idcustomer.Text;
                                elemen[1] = tbox_name.Text;
                                elemen[2] = cbox_gender.Text;
                                elemen[3] = cbox_idtype.Text;
                                elemen[4] = tbox_idnumber.Text;
                                elemen[5] = datetime_birthdate.Text;
                                elemen[6] = tbox_address.Text;
                                txtsimpan = elemen[0] + "#" + elemen[1] + "#" + elemen[2] + "#" + elemen[3] + "#" + elemen[4] + "#" + elemen[5] + "#" + elemen[6] + "\n";
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
                        File.WriteAllText("Customer.txt", alltext);
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please Correct The Field Above");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found !");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
