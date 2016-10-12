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
    public partial class UpdateAirplane : Form
    {
        public UpdateAirplane()
        {
            InitializeComponent();
        }

        public void clear()
        {
            tbox_search.Text = "";
            tbox_idairplane.Text = ""; 
            tbox_nameairplane.Text = "";
            cbox_typeairplane.Text = "";
            numeric_totalseat.Value = 0;
            cbox_status.Text = "";
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            string line, cari;
            string[] strArray = new string[5];
            Boolean find = false;
            FileStream F;
            StreamReader R;
            F = new FileStream("Airplane.txt", FileMode.Open, FileAccess.Read);
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
                    tbox_idairplane.Text = strArray[0];
                    tbox_nameairplane.Text = strArray[1];
                    cbox_typeairplane.Text = strArray[2];
                    numeric_totalseat.Text = strArray[3];
                    cbox_status.Text = strArray[4];
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
                    error_addairplane.Clear();
                    FileStream F;
                    StreamReader R;
                    try
                    {
                        string cari, Str;
                        string[] strArray = new string[5];
                        Boolean find = false;
                        int Pos;
                        string alltext = "";
                        string txtsimpan = "";
                        F = new FileStream("Airplane.txt", FileMode.Open, FileAccess.Read);
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
                                elemen[0] = tbox_idairplane.Text;
                                elemen[1] = tbox_nameairplane.Text;
                                elemen[2] = cbox_typeairplane.Text;
                                elemen[3] = numeric_totalseat.Value.ToString();
                                elemen[4] = cbox_status.Text;
                                txtsimpan = elemen[0] + "#" + elemen[1] + "#" + elemen[2] + "#" + elemen[3] + "#" + elemen[4]+ "\n" ;
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
                        File.WriteAllText("Airplane.txt", alltext);

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
                catch (FileNotFoundException)
                    {
                        MessageBox.Show("No One Registered Yet");
                    }
        }
    }
}
