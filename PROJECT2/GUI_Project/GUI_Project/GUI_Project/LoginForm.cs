using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GUI_Project
{
    public partial class LoginForm : Form
    {
        FileStream F;
        StreamReader R;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                errorProvider1.Clear();
                loginValidation();
                tssWarning.Text = "";
            }
            else
            {
                MessageBox.Show("Correct The Error(s)");
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            tssWarning.Text = "Please Enter Your Username";
        }

        private void txtPswrd_Enter(object sender, EventArgs e)
        {
            tssWarning.Text = "Please Enter Your Password";
        }

        private int ValidateData()
        {
            int flag = 0;
            if (txtUser.Text == "")
            {
                txtUser.Focus();
                errorProvider1.SetError(txtUser, "Please Fill In The Username");
                flag = 1;
            }
            if (txtPswrd.Text == "")
            {
                txtPswrd.Focus();
                errorProvider1.SetError(txtPswrd, "Please Fill In The Password");
                flag = 1;
            }
            return flag;
        }
        private void loginValidation()
        {
            F = new FileStream("Admin.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);
            Boolean find = false, valid = false;
            string cari, line;
            cari = txtUser.Text;

            while ((line = R.ReadLine()) != null)
            {
                find = true;
                int stringStartPos = line.IndexOf('#');
                if (cari.Equals(line.Substring(0, stringStartPos)))
                {
                    String[] elemen = line.Split('#');
                    if (txtPswrd.Text.Equals(elemen[1]))
                    {
                        if (txtUser.Text.Equals(elemen[0]) && elemen[2].Equals("1"))
                        {
                            MessageBox.Show("Sucess Login");
                            this.Hide();
                            FormBack frm = new FormBack();
                            frm.Show();
                            valid = true;
                        }
                        else if (txtUser.Text.Equals(elemen[0]) && elemen[2].Equals("2"))
                        {
                            MessageBox.Show("Sucess Login");
                            LoginForm lgnfrm2 = new LoginForm();
                            this.Hide();
                            ReservationForm frmup = new ReservationForm();
                            frmup.Show();
                            valid = true;
                        }
                        else if (txtUser.Text.Equals(elemen[0]) && elemen[2].Equals("3"))
                        {
                            MessageBox.Show("Sucess Login");
                            LoginForm lgnfrm2 = new LoginForm();
                            this.Hide();
                            AdminForm frmup = new AdminForm();
                            frmup.Show();
                            valid = true;
                        }
                    }
                }
            }
            if (!valid)
            {
                MessageBox.Show("Wrong Username or Password");
            }
            if (!find)
            {
                MessageBox.Show("No One Account Registered");
            }
            R.Close();
            F.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
