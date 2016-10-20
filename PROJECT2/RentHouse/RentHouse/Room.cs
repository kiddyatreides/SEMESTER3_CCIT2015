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
    public partial class Room : Form
    {

        DataTable dt;
        DataRow dr;
        string code;

        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rent_houseDataSet.tb_type_room' table. You can move, or remove it, as needed.
            this.tb_type_roomTableAdapter.Fill(this.rent_houseDataSet.tb_type_room);
            // TODO: This line of code loads data into the 'rent_houseDataSet.tb_room' table. You can move, or remove it, as needed.
            this.tb_roomTableAdapter.Fill(this.rent_houseDataSet.tb_room);

            tb_idroom.Enabled = false;

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
            if (tb_price.Text == "")
            {
                tb_price.Focus();
                errorProvider1.SetError(tb_price, "Please Fill The Price");
                flag = 1;
            }
            return flag;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            tb_price.Text = "";
            cb_type.Text = "";
        

            int ctr, len;
            string codeval;
            dt = rent_houseDataSet.Tables["tb_room"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["id_room"].ToString();
            codeval = code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                tb_idroom.Text = "R00" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 99))
            {
                ctr = ctr + 1;
                tb_idroom.Text = "R0" + ctr;
            }
            else if (ctr >= 99)
            {
                ctr = ctr + 1;
                tb_idroom.Text = "R" + ctr;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into tb_room(id_room,name,price,id_type_room) values('" + this.tb_idroom.Text + "','" + this.tb_name.Text + "','" + this.tb_price.Text + "','" + this.cb_type.Text + "');";
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
                    string Query = "update tb_room set name='" + this.tb_name.Text + "',id_type_room='" + this.cb_type.Text + "',price='" + this.tb_price.Text + "' where id_room='" + this.tb_idroom.Text + "';";
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
    }
}
