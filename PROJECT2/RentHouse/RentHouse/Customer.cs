using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentHouse
{
    public partial class Customer : Form
    {

        DataTable dt;
        DataRow dr;
        string code;

        public Customer()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            
        }

        private void Customer_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rent_houseDataSet.tb_customer' table. You can move, or remove it, as needed.
            this.tb_customerTableAdapter.Fill(this.rent_houseDataSet.tb_customer);
            // TODO: This line of code loads data into the 'renthouseDataSet.tb_customer' table. You can move, or remove it, as needed.
            tb_idcust.Enabled = false;
            

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tb_idcust.Text = "";
            tb_name.Text = "";
            cb_type.Text = "";
            tb_idno.Text = "";
            cb_gender.Text = "";
            tb_phone.Text = "";
            tb_address.Text = "";
            dt_birth.Value = DateTime.Now;

            int ctr, len;
            string codeval;
            dt = rent_houseDataSet.Tables["tb_customer"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["id_customer"].ToString();
            codeval = code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                tb_idcust.Text = "C00" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 99))
            {
                ctr = ctr + 1;
                tb_idcust.Text = "C0" + ctr;
            }
            else if (ctr >= 99)
            {
                ctr = ctr + 1;
                tb_idcust.Text = "C" + ctr;
            }
        }

        private int ValidateData()
        {
            int flag = 0;
            if (tb_name.Text == "")
            {
                tb_name.Focus();
                errorProvider1.SetError(tb_name, "Please Fill in The Name");
                flag = 1;
            }
            if (cb_type.Text == "")
            {
                cb_type.Focus();
                errorProvider1.SetError(cb_type, "Please Fill in The Type");
                flag = 1;
            }
            if (cb_gender.Text == "")
            {
                cb_gender.Focus();
                errorProvider1.SetError(cb_gender, "Please Fill The Gender");
                flag = 1;
            }
            if (tb_idno.Text == "")
            {
                tb_idno.Focus();
                errorProvider1.SetError(tb_idno, "Please Fill The ID Number");
                flag = 1;
            }
            if (dt_birth.Value.Year > 2000 )
            {
                dt_birth.Focus();
                errorProvider1.SetError(dt_birth, "Age must be above 17 years Old");
                flag = 1;
            }
            if (tb_phone.Text == "")
            {
                tb_phone.Focus();
                errorProvider1.SetError(tb_phone, "Please Fill The Phone Number");
                flag = 1;
            }
            if (tb_address.Text == "")
            {
                tb_address.Focus();
                errorProvider1.SetError(tb_address, "Please Fill The Address");
                flag = 1;
            }
            return flag;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into tb_customer values('" + this.tb_idcust.Text + "','" + this.tb_name.Text + "','" + this.cb_type.Text + "','" + this.tb_idno.Text + "','" + this.cb_gender.Text + "','" + this.dt_birth.Text + "','" + this.tb_phone.Text + "','" + this.tb_address.Text + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Data Has Been Added");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Fix The Error");
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (ValidateData() == 0)
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "update tb_customer set name='" + this.tb_name.Text + "',card_type='" + this.cb_type.Text + "',id_no='" + this.tb_idno.Text + "',gender='" + this.cb_gender.Text + "',birthdate='" + this.dt_birth.Text + "',phone='" + this.tb_phone.Text + "',address='" + this.tb_address.Text + "' where id_customer ='" + this.tb_idcust.Text + "';";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Data Has Been Updated");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Fix The Error");
            }

        }

        private void tb_idcust_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
